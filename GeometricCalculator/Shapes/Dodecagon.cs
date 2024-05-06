using System;

namespace Shapes
{
    // Dodecagon class is a subclass of TwoDimensionalShape class
    public class Dodecagon : TwoDimensionalShape
    {
        private double sideLength;

        public Dodecagon(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(3) * sideLength * sideLength;
        }

        public override double Perimeter()
        {
            return 12 * sideLength;
        }
    }
}