using System;

namespace Shapes
{
    // Decagon class is a subclass of TwoDimensionalShape class
    public class Decagon : TwoDimensionalShape
    {
        // Properties
        public double side { get; set; }

        // Constructor
        public Decagon(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return 2.5 * side * side * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }

        public override double Perimeter()
        {
            return 10 * side;
        }
    }
}