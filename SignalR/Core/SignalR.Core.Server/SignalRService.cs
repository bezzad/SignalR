using System.ServiceProcess;
using Microsoft.Owin;
using SignalR.Core;

[assembly: OwinStartup(typeof(Startup))]
namespace SignalR.Core
{
    public partial class SignalRService : ServiceBase
    {
        public SignalRService()
        {
            InitializeComponent();

            this.ServiceName = this.GetType().Name;
        }

        protected override void OnStart(string[] args)
        {
            WindowsEventLog.WriteInfoLog(string.Format("{0} Starting...", this.ServiceName));

            StartServer();
        }

        protected override void OnStop()
        {
            WindowsEventLog.WriteErrorLog(string.Format("{0} Stopped.", this.ServiceName));
        }

        protected override void OnContinue()
        {
            WindowsEventLog.WriteWarningLog(string.Format("{0} Continued.", this.ServiceName));
        }

        protected override void OnPause()
        {
            WindowsEventLog.WriteWarningLog(string.Format("{0} Paused.", this.ServiceName));
        }

    }
}
