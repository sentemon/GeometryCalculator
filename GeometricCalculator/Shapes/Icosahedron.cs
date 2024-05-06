using System;

namespace Shapes
{
    // Icosahedron class is a subclass of ThreeDimensionalShape class
    public class Icosahedron : ThreeDimensionalShape
    {
        private double sideLength;

        public Icosahedron(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Volume()
        {
            return (5.0 / 12.0) * (3 + Math.Sqrt(5)) * Math.Pow(sideLength, 3);
        }

        public override double Area()
        {
            return 5 * Math.Sqrt(3) * Math.Pow(sideLength, 2);
        }

        public override double Perimeter()
        {
            return 30 * sideLength;
        }
    }
}