using System;

namespace Shapes 
{
    // Circle class is a subclass of TwoDimensionalShape class
    public class Circle : TwoDimensionalShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}