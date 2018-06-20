using NClass.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NClass.CodeGenerator
{
    public class CodeGenerationModel
    {
        public string Destination { get; set; }
        public IList<string> Usings { get; set; } = new List<String>();
        public bool HasNotImplementedException { get; set; }
        public int IndentSize { get; set; }
        public bool UseTabsForIndent { get; set; }
        public SolutionType Solution { get; set; }
        public Language Language { get; set; }

       
    }
}
