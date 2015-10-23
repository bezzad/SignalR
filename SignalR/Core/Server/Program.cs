using System.ServiceProcess;

namespace SignalR.Core
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            WindowsEventLog.CreateEventLog();

            ServiceBase[] ServicesToRun;

            ServicesToRun = new ServiceBase[] 
            { 
                new SignalRService() 
            };

            //ServiceBase.Run(ServicesToRun);
            ServicesToRun.SelectWhatDoing(args);
        }
    }
}