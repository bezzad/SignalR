using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using SignalR.Core.Model;

namespace SignalR.Core
{
    public class Client : Finalizer, ISharedHub
    {
        #region Properties

        protected CultureInfo Culture;
        protected IHubProxy HubProxy { get; set; }
        protected HubConnection Connection { get; set; }
        public string Username { get; set; }

        public ConnectionState State
        {
            get { return Connection.State; }
        }

        #endregion

        #region Events

        public event LogHandler RaiseLog = delegate { };

        public delegate void LogHandler(string resourceCode);

        public virtual void OnRaiseLog(string message)
        {
            LogHandler handler = RaiseLog;
            if (handler != null) handler(message);
        }


        public event ErrorHandler Error = delegate { };

        public delegate void ErrorHandler(Exception exp);

        public virtual void OnError(Exception exp)
        {
            Error(exp);
        }


        public event ConnectionClosed Closed = delegate { };

        public delegate void ConnectionClosed();

        public virtual void OnConnectionClosed()
        {
            Closed();
        }


        public event StateChanged ConnectionStateChanged = delegate { };

        public delegate void StateChanged(Microsoft.AspNet.SignalR.Client.StateChange connectionState);

        public virtual void OnConnectionStateChanged(Microsoft.AspNet.SignalR.Client.StateChange connectionstate)
        {
            ConnectionStateChanged(connectionstate);
        }


        public event ExecuteCSharpCodesAcknowledge ExecuteAcknowledge = delegate { };

        public delegate void ExecuteCSharpCodesAcknowledge(string state, string username, string exception);

        public virtual void OnExecuteAcknowledge(string state, string username, string exception)
        {
            ExecuteCSharpCodesAcknowledge handler = ExecuteAcknowledge;
            if (handler != null) handler(state, username, exception);
        }


        public event FetchBase64String FetchImage = delegate { };

        public delegate void FetchBase64String(string data, string username);

        public virtual void OnFetchImage(string data, string username)
        {
            FetchBase64String handler = FetchImage;
            if (handler != null) handler(data, username);
        }


        public event StatusNotify StatusNotifyEvent = delegate { };

        public delegate void StatusNotify(string title, string message, string icon);

        public virtual void OnStatusNotify(string title, string message, string icon)
        {
            StatusNotify handler = StatusNotifyEvent;
            if (handler != null) handler(title, message, icon);
        }

        #endregion

        #region Constructors

        public Client(string url, CultureInfo culture)
        {
            Culture = culture;
            Connection = new HubConnection(url);
            Connection.Closed += OnConnectionClosed;
            Connection.Error += OnError;
            Connection.ConnectionSlow += () => OnError(new TimeoutException("Connection is too slow"));
            Connection.StateChanged += OnConnectionStateChanged;

            HubProxy = Connection.CreateHubProxy("SignalRHub");

            HubProxy.On<string>("OnRaiseLog", OnRaiseLog);
            HubProxy.On<string, object[]>("Call", Call);
            HubProxy.On<string, string, string[], object[]>("CallByType", CallByType);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates and connects the hub connection and hub proxy. This method
        /// is called asynchronously
        /// </summary>
        public async Task<bool> ConnectAsync()
        {
            ThrowExceptionIfDisposed();

            // Start
            try
            {
                await Connection.Start();

                return true;
            }
            catch (HttpRequestException)
            {
                OnError(
                    new HttpRequestException(
                        "SignalR client unable to connect to server; Start server before connecting clients."));

                return false;
            }
            catch (Exception exp)
            {
                OnError(exp);

                return false;
            }
        }


        /// <summary>
        /// Calls the specified method of this client from server.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="args">The arguments objects.</param>
        /// <returns></returns>
        public void Call(string method, params object[] args)
        {
            ThrowExceptionIfDisposed();

            var parametersType = Type.GetTypeArray(args);

            MethodInfo mi = this.GetType().GetMethod(method, parametersType);

            if (mi != null)
                mi.Invoke(this, args);
        }

        public void CallByType(string type, string method, string[] paramTypesAsembly, params object[] args)
        {
            if (paramTypesAsembly.Length != args.Length)
            {
                MessageBox.Show("Arguments out or less than parameters types number!");
                throw new ArgumentOutOfRangeException("Arguments out or less than parameters types number!");
            }
            //
            // Create reference type to call that type methods
            //
            Type methodType = Type.GetType(type);
            //
            // Convert paramTypesAsembly as string array to type array
            //
            Type[] types = paramTypesAsembly.Select(Type.GetType).ToArray();
            //
            // Set JSON converted objects to real type objects 
            // for example, every numbers in JSON are Int64 but may be real type is Int16
            //
            object[] parameters = args.Select((t, i) => Convert.ChangeType(t, types[i])).ToArray();
            //
            // Call method by real type parameters
            //
            if (methodType != null)
            {
                var mi = methodType.GetMethod(method, types);
                mi.Invoke(null, parameters);
            }
        }


        public async void ExecuteCSharpCodes(string codes, string username)
        {
            CompileResult res;
            if (CodeGenerator.TryBuild(codes, out res))
            {
                Exception exp = null;
                try
                {
                    await CallClientAsync(username, "OnExecuteAcknowledge", "Boiled", this.Username, "");
                    res.Method.Invoke(null, null);
                    await CallClientAsync(username, "OnExecuteAcknowledge", "Executed", this.Username, "");

                    return;
                }
                catch (Exception ex)
                {
                    exp = ex;
                }

                string error = string.Format("JIT exception from running dynamic assembly: \n {0}\n",
                    exp.Message);

                if (exp.InnerException != null)
                    error += string.Format("\t Inner exception: {0}\n", exp.InnerException.Message);

                await CallClientAsync(username, "OnExecuteAcknowledge", "NotExecuted", this.Username, error);
            }
            else
            {
                foreach (CompilerError error in res.Errors)
                {
                    await
                        CallClientAsync(username, "OnExecuteAcknowledge", "Failed", this.Username,
                            string.Format("{0} {1}:\t {2}\n at line {3}: {4}\n\n",
                                error.IsWarning ? "Warning" : "Error",
                                error.ErrorNumber,
                                error.ErrorText,
                                res.CodeMaps[error.Line].Item1,
                                res.CodeMaps[error.Line].Item2));
                }
            }
        }

        public async void GetDesktopCapture(string username, long width, long height, string imageFormat)
        {
            Image img = ScreenCapture.Capture();

            if (width > 0 && height > 0)
                img = img.ResizeImage((int)width, (int)height);

            if (img != null)
            {
                var format = (ImageFormat)(typeof(ImageFormat).GetProperty(imageFormat).GetValue(null));

                string img64 = img.ToBase64String(format);
                await CallClientAsync(username, "OnFetchImage", img64, Username);
            }
        }

        /// <summary>
        /// Add custom client methods
        /// </summary>
        public void AlertNotify(string title, string message, long timeout, string icon)
        {
            try
            {
                ToolTipIcon tipIcon = ToolTipIcon.Info;

                if (!icon.Equals("Information", StringComparison.OrdinalIgnoreCase)) // No information icon 
                    ToolTipIcon.TryParse(icon, true, out tipIcon);

                var notify = new NotifyIcon
                {
                    Text = message,
                    BalloonTipTitle = title,
                    BalloonTipText = message,
                    Icon = Core.Properties.Resources.Led,
                    Visible = true,
                    BalloonTipIcon = tipIcon
                };

                notify.BalloonTipClosed += (sender, args) =>
                {
                    notify.Visible = false;
                    notify.Dispose();
                };

                notify.ShowBalloonTip(unchecked((int)timeout));
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
        }

        public void MessageShower(string title, string message, string icon)
        {
            MessageBoxIcon msgIcon;
            if (MessageBoxIcon.TryParse(icon, true, out msgIcon))
                MessageBox.Show(message, title, MessageBoxButtons.OK, msgIcon);
        }


        public async Task<bool> UsernameVerificationAsync(string username, string password, string category)
        {
            var user = new User()
            {
                Domain = Environment.UserDomainName,
                Category = category,
                Username = username.ToLower(),
                Password = password,
                SystemUsername = Environment.UserName,
                EntryTime = DateTime.Now,
                IP = NetworkHelper.GetIpAddress(),
                MAC = NetworkHelper.GetMacAddress(),
                Culture = Culture.Name
            };

            return await UsernameVerificationAsync(user);
        }
        protected async Task<bool> UsernameVerificationAsync(User user)
        {
            if (user == null) return false;

            bool isValidUser = false;

            try
            {
                ThrowExceptionIfDisposed();

                isValidUser = await HubProxy.Invoke<bool>("UsernameVerificationAsync", user);

                this.Username = isValidUser ? user.Username : "";
                return isValidUser;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);

                isValidUser = false;
            }
            finally
            {
                if (!isValidUser)
                    Dispose();
            }

            return false;
        }

        #endregion

        #region Invoke Server Methods

        public async Task InvokeAsync(string serverMethod, params object[] args)
        {
            ThrowExceptionIfDisposed();

            await HubProxy.Invoke(serverMethod, args);
        }

        public async Task<T> InvokeAsync<T>(string serverMethod, params object[] args)
        {
            ThrowExceptionIfDisposed();

            return await HubProxy.Invoke<T>(serverMethod, args);
        }

        #endregion

        #region AddHandler to Server Methods

        public void AddHandler(string method, Action action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On(method, action);
        }

        public void AddHandler(string method, Action<dynamic> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On(method, action);
        }

        public void AddHandler<T>(string method, Action<T> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On<T>(method, action);
        }

        public void AddHandler<T1, T2>(string method, Action<T1, T2> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On<T1, T2>(method, action);
        }

        public void AddHandler<T1, T2, T3>(string method, Action<T1, T2, T3> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On<T1, T2, T3>(method, action);
        }

        public void AddHandler<T1, T2, T3, T4>(string method, Action<T1, T2, T3, T4> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On<T1, T2, T3, T4>(method, action);
        }

        public void AddHandler<T1, T2, T3, T4, T5>(string method, Action<T1, T2, T3, T4, T5> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On<T1, T2, T3, T4, T5>(method, action);
        }

        public void AddHandler<T1, T2, T3, T4, T5, T6>(string method, Action<T1, T2, T3, T4, T5, T6> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On<T1, T2, T3, T4, T5, T6>(method, action);
        }

        public void AddHandler<T1, T2, T3, T4, T5, T6, T7>(string method, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            ThrowExceptionIfDisposed();

            HubProxy.On<T1, T2, T3, T4, T5, T6, T7>(method, action);
        }

        #endregion

        #region Finalizer Implementation

        protected override void ReleaseManagedMemory()
        {
            if (Connection != null)
            {
                Connection.Stop();
                Connection.Dispose();
            }
        }

        #endregion

        #region ISharedHub Implementation

        #region Client Call method invokers

        public async Task CallAllClientsAsync(string method, params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallAllClientsAsync", method, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallOtherClientsAsync(string method, params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallOtherClientsAsync", method, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallCallerClientAsync(string method, params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallCallerClientAsync", method, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallClientAsync(string username, string method, params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallClientAsync", username, method, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallClientsAsync(List<string> usernames, string method, params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallClientsAsync", usernames, method, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallClientGroupsAsync(string[] groups, string method, params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallClientGroupsAsync", groups, method, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        #endregion

        #region Client CallByType method invokers

        public async Task CallByTypeAllClientsAsync(string type, string method, string[] paramTypes,
            params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallByTypeAllClientsAsync", type, method, paramTypes, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallByTypeOtherClientsAsync(string type, string method, string[] paramTypes,
            params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallByTypeOtherClientsAsync", type, method, paramTypes, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallByTypeCallerClientAsync(string type, string method, string[] paramTypes,
            params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallByTypeCallerClientAsync", type, method, paramTypes, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallByTypeClientAsync(string username, string type, string method, string[] paramTypes,
            params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallByTypeClientAsync", username, type, method, paramTypes, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallByTypeClientsAsync(List<string> usernames, string type, string method, string[] paramTypes,
            params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallByTypeClientsAsync", usernames, type, method, paramTypes, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        public async Task CallByTypeClientGroupsAsync(string[] groups, string type, string method, string[] paramTypes,
            params object[] args)
        {
            try
            {
                ThrowExceptionIfDisposed();

                await HubProxy.Invoke("CallByTypeClientGroupsAsync", groups, type, method, paramTypes, args);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.Source);
            }
        }

        #endregion


        #endregion

    }
}