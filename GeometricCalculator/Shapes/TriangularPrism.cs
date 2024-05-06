using System;

namespace Shapes
{
    // TriangularPrism class is a subclass of ThreeDimensionalShape class
    public class TriangularPrism : ThreeDimensionalShape
    {
        private double baseSide;
        private double height;
        private double side1;
        private double side2;
        private double side3;

        public TriangularPrism(double baseSide, double height, double side1, double side2, double side3)
        {
            this.baseSide = baseSide;
            this.height = height;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Volume()
        {
            return 0.5 * baseSide * height;
        }

        public override double Area()
        {
            return baseSide + side1 + side2 + side3;
        }

        public override double Perimeter()
        {
            return baseSide * height;
        }
    }
}