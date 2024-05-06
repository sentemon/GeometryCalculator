using System;

namespace Shapes
{
    // Cuboid class is a subclass of ThreeDimensionalShape class
    public class Cuboid : ThreeDimensionalShape
    {
        private double length;
        private double width;
        private double height;

        public Cuboid(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public override double Volume()
        {
            return length * width * height;
        }

        public override double Area()
        {
            return 2 * (length * width + length * height + width * height);
        }

        public override double Perimeter()
        {
            return 4 * (length + width + height);
        }
    }
}