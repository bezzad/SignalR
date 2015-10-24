using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using SignalR.Core.Extensions;

namespace WinFormClient
{
    public partial class ClientForm : Form
    {
        private CustomClient Client { get; set; }

        public ClientForm()
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("fa-IR");
            txtSender.KeyUp += txtSender_KeyUp;
        }

        async void txtSender_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                string msg = String.Format("{0}:\t{1}", Client.Username, SafePopText());

                WriteLog(msg);
                await Client.CallOtherClientsAsync("OnRaiseLog", msg);
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;

            Client = new CustomClient(GetUrl());
            Application.ApplicationExit += Application_ApplicationExit;
            Client.RaiseLog += msg => WriteLog(msg);
            Client.Error += WriteError;
            Client.ConnectionStateChanged += ConnectionStateChanged;

            if (await Client.ConnectAsync())
            {
                bool isValid = await Client.UsernameVerificationAsync(txtUsername.Value, txtPassword.Value, txtCategory.Value);

                ActiveControls(isValid);
            }
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            Client.Dispose();
        }

        void ConnectionStateChanged(Microsoft.AspNet.SignalR.Client.StateChange state)
        {
            Invoke(new Action(() => btnConnect.Text = state.NewState.ToString()));

            ActiveControls(state.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected);

            if (state.OldState == ConnectionState.Reconnecting && state.NewState == ConnectionState.Disconnected)
            {
                WaitSplash.DockOnControlThreadSafe(this);
            }
            else if (state.NewState == ConnectionState.Reconnecting)
            {
                WaitSplash.DockOnControlThreadSafe(this);
            }
            else if (state.NewState == ConnectionState.Connected)
            {
                WaitSplash.Hide();
            }
        }

        public string GetUrl()
        {
            string ip = string.IsNullOrEmpty(txtIP.Value) ? "localhost" : txtIP.Value;
            string port = string.IsNullOrEmpty(txtPort.Value) ? "50023" : txtPort.Value;

            string url = string.Format("http://{0}:{1}/", ip, port);

            return url;
        }

        public void WriteLog(string format, params string[] args)
        {
            txtLog.AppendText(string.Format(format, args), Color.Black);
            txtLog.AppendText(Environment.NewLine, Color.Black);
        }

        public void WriteError(Exception exp)
        {
            txtLog.AppendText(string.Format("Error [{0}]: \t{1}", exp.GetType().Name, exp.Message), Color.Red);
            txtLog.AppendText(Environment.NewLine, Color.Red);

            if (exp.InnerException != null)
            {
                txtLog.AppendText("\t At ", Color.Red);
                WriteError(exp.InnerException);
            }
        }

        public void ActiveControls(bool connected)
        {
            if (connected)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => ActiveControls(true)));
                }
                else
                {
                    txtSender.Enabled = true;
                    txtPort.Enabled = false;
                    txtUsername.Enabled = false;
                    txtIP.Enabled = false;
                    txtPort.Enabled = false;
                    btnConnect.Enabled = false;
                    btnConnect.Check();
                }
            }
            else
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => ActiveControls(false)));
                }
                else
                {
                    txtSender.Enabled = false;
                    txtPort.Enabled = true;
                    txtUsername.Enabled = true;
                    txtIP.Enabled = true;
                    txtPort.Enabled = true;
                    btnConnect.Enabled = true;
                    btnConnect.UnCheck();
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (Client != null)
                Client.Dispose();
        }

        private string SafePopText()
        {
            string msg = txtSender.Text;
            if (txtSender.InvokeRequired)
            {
                txtSender.Invoke(new Action(() => txtSender.Clear()));
            }
            else
            {
                txtSender.Clear();
            }

            return msg;
        }
    }
}