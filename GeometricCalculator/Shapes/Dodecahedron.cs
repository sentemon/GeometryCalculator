using System;

namespace Shapes
{
    // Dodecahedron class is a subclass of ThreeDimensionalShape class
    public class Dodecahedron : ThreeDimensionalShape
    {
        private double edgeLength;

        public Dodecahedron(double edgeLength)
        {
            this.edgeLength = edgeLength;
        }

        public override double Volume()
        {
            return (15 + 7 * Math.Sqrt(5)) / 4 * Math.Pow(edgeLength, 3);
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * Math.Pow(edgeLength, 2);
        }

        public override double Perimeter()
        {
            return 30 * edgeLength;
        }
    }
}