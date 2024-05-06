using System;

namespace Shapes
{
    // Hendecagon class is a subclass of TwoDimensionalShape class
    public class Hendecagon : TwoDimensionalShape
    {
        private double sideLength;

        public Hendecagon(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return 11 * sideLength * sideLength / (4 * Math.Tan(Math.PI / 11));
        }

        public override double Perimeter()
        {
            return 11 * sideLength;
        }
    }
}