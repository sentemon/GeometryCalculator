using System;

namespace Shapes
{
    // Octagon class is a subclass of TwoDimensionalShape class
    public class Octagon : TwoDimensionalShape
    {
        // Properties
        public double side { get; set; }

        // Constructor
        public Octagon(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(side, 2);
        }

        public override double Perimeter()
        {
            return 8 * side;
        }
    }
}