using System;

namespace Shapes
{
    // PentagonalPrism class is a subclass of ThreeDimensionalShape class
    public class PentagonalPrism : ThreeDimensionalShape
    {
        private double sideLength;
        private double height;

        public PentagonalPrism(double sideLength, double height)
        {
            this.sideLength = sideLength;
            this.height = height;
        }

        public override double Volume()
        {
            return 5 * sideLength * height;
        }

        public override double Area()
        {
            return 5 * sideLength * sideLength + 5 * sideLength * height;
        }

        public override double Perimeter()
        {
            return 5 * sideLength;
        }
    }
}