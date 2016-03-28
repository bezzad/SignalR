using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientsController.Properties;
using ClientsController.View;
using SignalR.Core;
using SignalR.Core.Model;
using SignalR.Core.Presenter;

namespace ClientsController.Presenter
{
    public class MainControllerPresenter : Presenter<IMainControllerView>
    {
        public MainControllerPresenter(IMainControllerView view, IModel model)
            : base(view)
        {
            Model = model;
        }
        
        public async void Connect()
        {
            try
            {
                View.ServerControlsEnable = false;

                if (View.Username != Resources.Username || View.Password != Resources.Password)
                {
                    throw new Exception("Your username or password is not correct");
                }

                CustomClient.Url = GetUrl();
                CustomClient.Instance.RaiseLog += msg => WriteLog(msg);
                CustomClient.Instance.Closed += () => View.ActiveControls(false);
                CustomClient.Instance.Error += WriteError;
                CustomClient.Instance.ConnectionStateChanged += ConnectionStateChanged;
                CustomClient.Instance.FetchImage += OnFetchImage;

                if (await CustomClient.Instance.ConnectAsync())
                {
                    ((User)Model).Username = View.Username;
                    ((User)Model).Password = View.Password;
                    ((User)Model).Category = "Administrators";

                    bool isValid = await CustomClient.Instance.UsernameVerificationAsync(View.Username, View.Password, "Administrators");

                    View.ActiveControls(isValid);

                    if (isValid)
                    {
                        await FetchUsersData();

                        View.SetColumns();
                    }
                }
            }
            catch (Exception exp)
            {
                View.ServerControlsEnable = true;

                View.Message = exp.Message;
            }
        }
        
        public void ShowServerEventLogs()
        {
            var slv = new ServerLogViewer();
            slv.ShowDialog((Form)View);
        }
        
        void ConnectionStateChanged(Microsoft.AspNet.SignalR.Client.StateChange state)
        {
            View.ConnectionState = state.NewState.ToString();

            View.ActiveControls(state.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected);
        }

        private string GetUrl()
        {
            string ip = string.IsNullOrEmpty(View.ServerIP) ? "localhost" : View.ServerIP;
            string port = string.IsNullOrEmpty(View.ServerPort) ? "50023" : View.ServerPort;

            string url = string.Format("http://{0}:{1}/", ip, port);

            return url;
        }

        public void WriteLog(string format, params object[] args)
        {
            View.Message = string.Format(format, args);
        }

        public void WriteError(Exception exp)
        {
            string msg = "";

            WriteErrorByRef(exp, ref msg);

            View.Message = msg;
        }

        public void WriteErrorByRef(Exception exp, ref string msg)
        {
            msg += string.Format("Error [{0}]: \t{1}{2}", exp.GetType().Name, exp.Message, Environment.NewLine);

            if (exp.InnerException != null)
            {
                msg += "\t At ";
                WriteErrorByRef(exp.InnerException, ref msg);
            }
        }
        
        void OnFetchImage(string data, string username)
        {
            var cdr = new ClientDesktopRemoter(data, username);

            SafeInvoker(cdr.Show);
        }
        
        public async Task FetchUsersData()
        {
            var users = await CustomClient.Instance.GetUsersAsync();

            View.Users = users;
        }
        
        public void ControlSelectedUsers(List<User> users)
        {
            if (users.Count > 0)
            {
                var ucpf = new UsersControlPanelForm(users);

                ucpf.Show((Form)View);
            }
            else
            {
                View.Message = "Please first select at least one user from users list to control it.";
            }
        }

    }
}
