using System;

namespace Shapes
{
    // Pentagon class is a subclass of TwoDimensionalShape class
    public class Pentagon : TwoDimensionalShape
    {
        // Constants
        private const double pentagonRatio = 1.720477401;

        // Properties
        public double side { get; set; }

        // Constructor
        public Pentagon(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return pentagonRatio * Math.Pow(side, 2);
        }

        public override double Perimeter()
        {
            return 5 * side;
        }
    }
}