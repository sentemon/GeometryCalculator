using System;

namespace Shapes
{
    // Crescent class is a subclass of TwoDimensionalShape class
    public class Crescent : TwoDimensionalShape
    {
        private double radius1;
        private double radius2;

        public Crescent(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }

        public override double Area()
        {
            return Math.PI * (radius1 * radius1 - radius2 * radius2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius1;
        }
    }
}