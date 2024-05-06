using System;

namespace Shapes
{
    // Pyramid class is a subclass of ThreeDimensionalShape class
    public class Pyramid : ThreeDimensionalShape
    {
        private double baseArea;
        private double height;

        public Pyramid(double baseArea, double height)
        {
            this.baseArea = baseArea;
            this.height = height;
        }

        public override double Volume()
        {
            return (baseArea * height) / 3;
        }

        public override double Area()
        {
            return baseArea + (0.5 * Perimeter() * SlantHeight());
        }

        public override double Perimeter()
        {
            return 4 * Math.Sqrt(Math.Pow(baseArea, 2) + Math.Pow(0.5 * height, 2));
        }

        private double SlantHeight()
        {
            return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(0.5 * Perimeter(), 2));
        }
    }
}