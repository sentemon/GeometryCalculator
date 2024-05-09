using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace GeometricCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Run.Welcome();
            Features.WriteShapes();
            Run.StartProgram();
        }
    }
}

