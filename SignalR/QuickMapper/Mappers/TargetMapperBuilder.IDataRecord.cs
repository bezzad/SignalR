using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Reflection;
using System.Text;
using Microsoft.CSharp;

namespace Express.ObjectMapper.Mappers
{
    internal partial class TargetMapperBuilder
    {
        /// <summary>
        /// Builds the specified type by
        /// Evaluates C# source language
        /// </summary>
        /// <param name="source"></param>
        /// <param name="targetType">The type.</param>
        /// <returns></returns>
        public MethodInfo Build(IDataRecord source, Type targetType)
        {
            string tOut = targetType.FullName;
            string typeNamespace = targetType.Namespace;

            CSharpCodeProvider c = new CSharpCodeProvider();
#pragma warning disable 618
            ICodeCompiler icc = c.CreateCompiler();
#pragma warning restore 618
            CompilerParameters cp = new CompilerParameters();

            cp.ReferencedAssemblies.Add("system.dll");
            cp.ReferencedAssemblies.Add("system.xml.dll");
            cp.ReferencedAssemblies.Add("system.data.dll");
            cp.ReferencedAssemblies.Add("mscorlib.dll");
            //cp.ReferencedAssemblies.Add("QuickMapper.dll");
            if (!targetType.IsMicrosoftType())
                cp.ReferencedAssemblies.Add(targetType.Assembly.ManifestModule.FullyQualifiedName);

            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;


            StringBuilder sb = new StringBuilder("");
            sb.Append("using System; \n");
            sb.Append("using System.Xml; \n");
            sb.Append("using System.Data; \n");
            //sb.Append("using Express.ObjectMapper; \n");
            if (typeNamespace != "System" && typeNamespace != "System.Xml" && typeNamespace != "System.Data")
                sb.Append(String.Format("using {0}; \n", typeNamespace));

            sb.Append("namespace DynamicAssemblyInRuntime \n");
            sb.Append("{ \n");
            sb.Append("    public static class CSharpCodeEvaler \n");
            sb.Append("    { \n");
            sb.Append("        public static #TOut EvalCode(IDataRecord record) \n");
            sb.Append("        {");
            sb.Append("            #CSharpCodesToReturnTOutObject \n");
            sb.Append("        } // EOF method \n");
            sb.Append("    } // EOF class \n");
            sb.Append("} // EOF namespace \n");

            //
            // Generate Code within 'EvalCode' method
            //
            string sCSCode = targetType == typeof(object)
                ? DynamicDataRecordCodeGenerator(source)
                : DataRecordCodeGenerator(targetType);

            sb.Replace("#CSharpCodesToReturnTOutObject", sCSCode); // insert generated codes
            sb.Replace("#TOut", tOut);
            CompilerResults cr = icc.CompileAssemblyFromSource(cp, sb.ToString());
            if (cr.Errors.Count > 0)
            {
                throw new EvaluateException("ERROR: " + cr.Errors[0].ErrorText);
            }

            System.Reflection.Assembly a = cr.CompiledAssembly;

            Type t = a.GetType("DynamicAssemblyInRuntime.CSharpCodeEvaler");
            MethodInfo mi = t.GetMethod("EvalCode");

            return mi;
        }

        private string DynamicDataRecordCodeGenerator(IDataRecord source)
        {
            StringBuilder objectCreator = new StringBuilder("");

            objectCreator.Append(string.Format("{0}return new {0}{1}", FirstTab, "{"));

            for (int index = 0; index < source.FieldCount; index++)
            {
                // example: Address = (string)record[0],
                objectCreator.Append(string.Format("{0}   {1} = record.IsDBNull({3}) ? default({4}) : ({2})record[{3}],",
                    FirstTab,
                    source.GetName(index),
                    source.GetFieldType(index).FullName,
                    index,
                    source.GetFieldType(index)));
            }

            string body = objectCreator.ToString().TrimEnd(',') + FirstTab + "};";

            return body;
        }


        private string DataRecordCodeGenerator(Type type)
        {
            StringBuilder objectCreator = new StringBuilder("");

            objectCreator.Append(string.Format("{0}int index; \n", FirstTab));
            objectCreator.Append(string.Format("{0}{1} outObject; \n", FirstTab, type.FullName));

            StringBuilder body = DataRecordBodyGenerator(type, "outObject", ref objectCreator);

            body.Append(string.Format("{0}return outObject; \n", FirstTab));
            objectCreator.Append(body.ToString());

            return objectCreator.ToString();
        }

        private StringBuilder DataRecordBodyGenerator(Type type, string localLabel, ref StringBuilder objectCreator)
        {
            string tOut = type.FullName;
            StringBuilder body = new StringBuilder("");

            objectCreator.Append(string.Format("{0}{2} = new {1}(); \n", FirstTab, tOut, localLabel));

            var properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!property.PropertyType.IsMicrosoftType()) // Property Type is a user-defined class
                {
                    body.Append(DataRecordBodyGenerator(property.PropertyType, localLabel + "." + property.Name, ref objectCreator).ToString());
                }
                else
                {
                    body.Append(string.Format("{0}index = record.GetOrdinal(\"{1}\");", FirstTab, property.Name));
                    body.Append(string.Format("{0}if (index >= 0 && !record.IsDBNull(index))", FirstTab));
                    body.Append(string.Format("{0}\t{1}.{2} = ({3})record[\"{2}\"];{0}", FirstTab, localLabel, property.Name, property.PropertyType.FullName));
                }
            }

            return body;
        }
    }
}