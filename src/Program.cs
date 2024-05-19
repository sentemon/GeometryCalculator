using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace GeometryCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "GeometryCalculator";
            Console.Clear();
            Run.Welcome();
            Help.ShowHelp();
            Features.WriteShapes();
            Run.StartProgram();
        }
    }
}

