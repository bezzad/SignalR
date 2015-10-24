using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace SignalR.Core
{
    /// <summary>
    /// Used by OWIN's startup process. 
    /// </summary>
    public class Startup
    {
        static Startup()
        {
            // Any connection or hub wire up and configuration should go here
            GlobalHost.HubPipeline.AddModule(new ErrorHandlingPipelineModule());
            //
            // SignalR features Configuration
            //
            GlobalHost.Configuration.MaxIncomingWebSocketMessageSize = 50 * 1024 * 1024; // 50MB
            GlobalHost.Configuration.DefaultMessageBufferSize = 50 * 1024 * 1024; // 50MB
            GlobalHost.Configuration.DisconnectTimeout = TimeSpan.FromSeconds(30);
            GlobalHost.Configuration.KeepAlive = TimeSpan.FromSeconds(10);
            GlobalHost.Configuration.TransportConnectTimeout = TimeSpan.FromSeconds(30);
            GlobalHost.Configuration.LongPollDelay = TimeSpan.FromSeconds(0);
            GlobalHost.Configuration.ConnectionTimeout = TimeSpan.FromSeconds(110);
        }

        public void Configuration(IAppBuilder app)
        {
            // There are many different methods that you can override. For a complete list, see HubPipelineModule Methods.
            // HubPipelineModule: https://msdn.microsoft.com/en-us/library/jj918633(v=vs.111).aspx
            //
            app.UseCors(CorsOptions.AllowAll);
            //app.MapSignalR();
            app.Map("/signalr", map =>
            {
                // Setup the cores middleware to run before SignalR.
                // By default this will allow all origins. You can 
                // configure the set of origins and/or http verbs by
                // providing a cores options with a different policy.
                map.UseCors(CorsOptions.AllowAll);

                var hubConfiguration = new HubConfiguration
                {
                    // You can enable JSONP by uncommenting line below.
                    // JSONP requests are insecure but some older browsers (and some
                    // versions of IE) require JSONP to work cross domain
                    EnableJSONP = true
                };


                // Run the SignalR pipeline. We're not using MapSignalR
                // since this branch is already runs under the "/signalr"
                // path.
                map.RunSignalR(hubConfiguration);
            });

            /* 
            // SignalR v1.0
            // Turn cross domain on 
            var config = new HubConfiguration { EnableCrossDomain = true };
            // This will map out to http://localhost:8080/signalr 
            app.MapHubs(config); 
             */
        }
    }

}