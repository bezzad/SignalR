namespace SignalR.Core
{
    public static class HelperExtensions
    {
        public static string SplitProperties(this object obj)
        {
            var properties = obj.GetType().GetProperties();

            var res = "";
            foreach (var prop in properties)
            {
                res += string.Format("{0}={1}&", prop.Name, prop.GetValue(obj));
            }
            res = res.Substring(0, res.Length - 1);

            return res;
        }
    }
}