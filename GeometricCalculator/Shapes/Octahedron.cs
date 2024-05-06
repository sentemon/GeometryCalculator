using System;

namespace Shapes
{
    // Octahedron class is a subclass of ThreeDimensionalShape class
    public class Octahedron : ThreeDimensionalShape
    {
        private double side;

        public Octahedron(double side)
        {
            this.side = side;
        }

        public override double Volume()
        {
            return (Math.Sqrt(2) / 3) * Math.Pow(side, 3);
        }

        public override double Area()
        {
            return 2 * Math.Sqrt(3) * Math.Pow(side, 2);
        }

        public override double Perimeter()
        {
            return 12 * side;
        }
    }
}