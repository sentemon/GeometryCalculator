using System;

namespace Shapes
{
    // Nonagon class is a subclass of TwoDimensionalShape class
    public class Nonagon : TwoDimensionalShape
    {
        // Properties
        public double side { get; set; }

        // Constructor
        public Nonagon(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return (9 * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI / 9));
        }

        public override double Perimeter()
        {
            return 9 * side;
        }
    }
}