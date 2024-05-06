using System;

namespace Shapes
{
    // Rhombus class is a subclass of TwoDimensionalShape class
    public class Rhombus : TwoDimensionalShape
    {
        // Properties
        public double side { get; set; }
        public double height { get; set; }

        // Constructor
        public Rhombus(double side, double height)
        {
            this.side = side;
            this.height = height;
        }

        public override double Area()
        {
            return side * height;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }
}