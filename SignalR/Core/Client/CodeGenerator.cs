using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CSharp;

namespace SignalR.Core
{
    public static class CodeGenerator
    {
        /// <summary>
        /// Builds the specified type by
        /// Evaluates C# source language
        /// </summary>
        /// <param name="codes">The C# language codes for compile dynamic method</param>
        /// <param name="result">Return compiler errors, created dynamic method, compiled codes by code line</param>
        /// <returns>Is compiled success?</returns>
        public static bool TryBuild(string codes, out CompileResult result)
        {
            result = new CompileResult();
            CSharpCodeProvider c = new CSharpCodeProvider();

#pragma warning disable 618
            ICodeCompiler icc = c.CreateCompiler();
#pragma warning restore 618

            var cp = new CompilerParameters();

            string[] namespaces = AssemblyManager.GetNamespaces(codes);

            foreach (var name in AssemblyManager.GetAssembliesName(namespaces))
            {
                cp.ReferencedAssemblies.Add(name);
            }

            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;

            result.CodeMaps = CodeMapParser(codes);

            string precompiledCodes = string.Join("\n", result.CodeMaps.Values.Select(x => x.Item2));

            CompilerResults cr = icc.CompileAssemblyFromSource(cp, precompiledCodes);

            result.Errors = cr.Errors;

            if (cr.Errors.Count > 0)
            {
                result.Method = null;
                return false;
            }

            System.Reflection.Assembly a = cr.CompiledAssembly;

            Type t = a.GetType("DynamicAssemblyInRuntime.CSharpCodeEvaler");
            result.Method = t.GetMethod("EvalCode");

            return true;
        }


        internal static Dictionary<int, Tuple<int, string>> CodeMapParser(string codes)
        {
            var codeMaps = new Dictionary<int, Tuple<int, string>>();

            List<string> sourceCodes = codes.Split(new string[] { "\r\n", "\n\r" }, StringSplitOptions.None).ToList();
            int newSourceLine = 1;

            for (int i = 0; i < sourceCodes.Count; i++)
            {
                if (sourceCodes[i].IndexOf("#region", System.StringComparison.Ordinal) < 0
                    && sourceCodes[i].IndexOf("#endregion", System.StringComparison.Ordinal) < 0
                    && !string.IsNullOrWhiteSpace(sourceCodes[i]))
                {
                    codeMaps.Add(newSourceLine++, Tuple.Create(i+1, sourceCodes[i]));
                }
            }

            return codeMaps;
        }
    }
}