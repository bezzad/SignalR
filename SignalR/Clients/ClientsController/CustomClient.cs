using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Core;
using SignalR.Core.Model;

namespace ClientsController
{
    public class CustomClient : Client
    {
        private static CustomClient _instance;
        public static string Url { get; set; }

        public static CustomClient Instance
        {
            get
            {
                if (_instance == null || _instance.Disposed)
                    _instance = new CustomClient(Url);

                return _instance;
            }
        }


        public CustomClient(string url)
            : base(url, CultureInfo.CreateSpecificCulture("cs"))
        {
            System.Windows.Forms.Application.ApplicationExit += Application_ApplicationExit;
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            Dispose();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            ThrowExceptionIfDisposed();

            var users = await InvokeAsync<List<User>>("GetUsers");

            return users.ToList();
        }
    }
}
