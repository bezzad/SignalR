
namespace SignalR.Core
{
    public static class Resource
    {

        public static string HostPort
        {
            get { return "50023"; }
        }

        public static string HostAddress
        {
            get { return "http://+:" + HostPort + "/"; }
        }
    }
}

