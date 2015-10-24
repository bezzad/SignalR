using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;

namespace SignalR.Core
{
    public class CompileResult
    {
        public CompilerErrorCollection Errors { get; set; }

        public MethodInfo Method { get; set; }

        /// <summary>
        /// Gets or sets the code maps.  
        /// (int NewLine, Tuple(int SourceLine, string SourceCode) )
        /// </summary>
        /// <value>
        /// The code maps.
        /// </value>
        public Dictionary<int, Tuple<int, string>> CodeMaps { get; set; }
    }
}
