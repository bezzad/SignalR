using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR.Core
{
    /// <summary>
    /// Create a Hubs pipeline module that handles the OnIncomingError method. 
    /// The following example shows a pipeline module that logs errors, 
    /// followed by code in Startup.cs that injects the module into the Hubs pipeline.
    /// </summary>
    public class ErrorHandlingPipelineModule : HubPipelineModule
    {
        protected override void OnIncomingError(ExceptionContext exceptionContext, IHubIncomingInvokerContext invokerContext)
        {
            string message = string.Format("=> Exception {0}", exceptionContext.Error.Message);

            if (exceptionContext.Error.InnerException != null)
            {
                message += "\n\t=> Inner Exception " + exceptionContext.Error.InnerException.Message;
            }

            WindowsEventLog.WriteErrorLog(message);

            base.OnIncomingError(exceptionContext, invokerContext);

        }
    }
}
