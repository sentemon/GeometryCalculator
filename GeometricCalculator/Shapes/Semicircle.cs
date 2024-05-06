using System;

namespace Shapes
{
    // Semicircle class is a subclass of TwoDimensionalShape class
    public class Semicircle : TwoDimensionalShape
    {
        private double radius;

        public Semicircle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2) / 2;
        }

        public override double Perimeter()
        {
            return Math.PI * radius + 2 * radius;
        }
    }
}