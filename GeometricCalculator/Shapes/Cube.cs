using System;

namespace Shapes
{
    // Cube class is a subclass of ThreeDimensionalShape class
    public class Cube : ThreeDimensionalShape
    {
        // Properties
        public double side { get; set; }

        // Constructor
        public Cube(double side)
        {
            this.side = side;
        }

        public override double Volume()
        {
            return side * side * side;
        }

        public override double Area()
        {
            return 6 * side * side;
        }

        public override double Perimeter()
        {
            return 12 * side;
        }
    }
}