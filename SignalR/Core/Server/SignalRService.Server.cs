using System;
using System.Reflection;
using Microsoft.Owin.Hosting;

namespace SignalR.Core
{
    public partial class SignalRService : IDisposable
    {
        #region Properties

        private IDisposable SignalR { get; set; }

        #endregion



        #region Methods

        /// <summary>
        /// Starts the server and checks for error thrown when another server is already 
        /// running. This method is called asynchronously from Button_Start.
        /// </summary>
        public bool StartServer()
        {
            // This will *ONLY* bind to HostAddress, if you want to bind to all addresses
            // use http://*:8080 or http://+:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/en-us/library/system.net.httplistener.aspx 
            // for more information.

            try
            {
                // Adding several IP addresses or URL's also works with 
                // new StartOption("http://*:9000/") on Microsoft.Owin.Hosting 3.0.1. and
                // netsh http add urlacl http://*:9000/
                // or run your app as admin
                var opt = new StartOptions(Resource.HostAddress)
                {
                    ServerFactory = "Microsoft.Owin.Host.HttpListener"
                };
                //opt.Urls.Add("http://*:9000/");

                SignalR = WebApp.Start<Startup>(opt);
            }
            catch (TargetInvocationException)
            {
                WindowsEventLog.WriteErrorLog(
                    string.Format("Server failed to start. A server is already running on {0}\n\n",
                        Resource.HostAddress));

                return false;
            }
            catch (Exception ex)
            {
                WindowsEventLog.WriteErrorLog(string .Format("Server failed to start.\n\nError: {0}", ex.Message));

                return false;
            }

            WindowsEventLog.WriteInfoLog(string.Format("Server running at {0}\n\n", Resource.HostAddress));

            return true;
        }

        #endregion

        #region IDisposable Implementation

        public new void Dispose()
        {
            if (SignalR != null)
            {
                SignalR.Dispose();
            }
        }

        #endregion
    }
}
