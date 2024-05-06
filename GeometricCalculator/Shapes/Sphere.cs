using System;

namespace Shapes
{
    // Sphere class is a subclass of ThreeDimensionalShape class
    public class Sphere : ThreeDimensionalShape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }
    }
}