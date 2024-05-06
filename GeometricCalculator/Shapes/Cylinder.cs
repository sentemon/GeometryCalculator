using System;

namespace Shapes
{
    // Cylinder class is a subclass of ThreeDimensionalShape class
    public class Cylinder : ThreeDimensionalShape
    {
        // Properties
        public double radius { get; set; }
        public double height { get; set; }

        // Constructor
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double Volume()
        {
            return Math.PI * radius * radius * height;
        }

        public override double Area()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}