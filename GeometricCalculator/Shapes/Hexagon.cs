using System;

namespace Shapes
{
    // Hexagon class is a subclass of TwoDimensionalShape class
    public class Hexagon : TwoDimensionalShape
    {
        // Properties
        public double side { get; set; }

        // Constructor
        public Hexagon(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(3) * Math.Pow(side, 2) / 2;
        }

        public override double Perimeter()
        {
            return 6 * side;
        }
    }
}