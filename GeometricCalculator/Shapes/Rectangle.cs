using System;

namespace Shapes
{
    // Rectangle class is a subclass of TwoDimensionalShape class
    public class Rectangle : TwoDimensionalShape
    {
        // Properties
        public double length { get; set; }
        public double width { get; set; }

        // Constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}