using System;

namespace Shapes
{
    // Parallelogram class is a subclass of TwoDimensionalShape class
    public class Parallelogram : TwoDimensionalShape
    {
        // Properties
        public double baseSide { get; set; }
        public double height { get; set; }

        // Constructor
        public Parallelogram(double baseSide, double height)
        {
            this.baseSide = baseSide;
            this.height = height;
        }

        public override double Area()
        {
            return baseSide * height;
        }

        public override double Perimeter()
        {
            return 2 * (baseSide + height);
        }
    }
}