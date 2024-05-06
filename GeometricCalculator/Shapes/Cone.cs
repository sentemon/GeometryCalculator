using System;

namespace Shapes
{
    // Cone class is a subclass of ThreeDimensionalShape class
    public class Cone : ThreeDimensionalShape
    {
        // Properties
        public double radius { get; set; }
        public double height { get; set; }

        // Constructor
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height / 3;
        }
    }
}