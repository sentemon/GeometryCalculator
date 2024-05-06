using System;

namespace Shapes
{
    // Oval class is a subclass of TwoDimensionalShape class
    public class Oval : TwoDimensionalShape
    {
        private double radius1;
        private double radius2;

        public Oval(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }

        public override double Area()
        {
            return Math.PI * radius1 * radius2;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(radius1, 2) + Math.Pow(radius2, 2)) / 2);
        }
    }
}