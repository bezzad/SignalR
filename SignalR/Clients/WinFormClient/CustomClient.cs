
using System.Globalization;
using SignalR;
using SignalR.Core;

namespace WinFormClient
{
    public class CustomClient : Client
    {
        public CustomClient(string url)
            : base(url, CultureInfo.CreateSpecificCulture("fa-IR"))
        {

        }

        
    }
}
