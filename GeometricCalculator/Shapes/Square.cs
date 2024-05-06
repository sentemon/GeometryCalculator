using System;

namespace Shapes
{
    // Square class is a subclass of TwoDimensionalShape class
    public class Square : TwoDimensionalShape
    {
        // Properties
        public double side { get; set; }

        // Constructor
        public Square(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }
}