using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SignalR.Core
{
    public static class AssemblyManager
    {
        public static string[] GetNamespaces(string codes)
        {
            var regex = new Regex(@"using \w+(\.\w+)*;");
            var usings = regex.Matches(codes);


            return (from Match @using in usings select @using.Value.Replace("using ", "").Replace(";", "").Trim()).ToArray();
        }

        public static string[] GetAssembliesName(string[] @namespaces)
        {
            return @namespaces.SelectMany(GetAssembliesName).Distinct().ToArray();
        }

        public static string[] GetAssembliesName(string @namespace)
        {
            return (from asm in AppDomain.CurrentDomain.GetAssemblies()
                    where asm.GetTypes().Any(type => type.Namespace != null
                        && type.Namespace.Equals(@namespace, StringComparison.OrdinalIgnoreCase))
                    select asm.ManifestModule.FullyQualifiedName).ToArray();
        }
    }
}