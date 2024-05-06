using System;

namespace Shapes
{
    // Trapezoid class is a subclass of TwoDimensionalShape class
    public class Trapezoid : TwoDimensionalShape
    {
        // Properties
        public double base1 { get; set; }
        public double base2 { get; set; }
        public double height { get; set; }

        // Constructor
        public Trapezoid(double base1, double base2, double height)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.height = height;
        }

        public override double Area()
        {
            return (base1 + base2) * height / 2;
        }

        public override double Perimeter()
        {
            return base1 + base2 + 2 * Math.Sqrt(Math.Pow((base1 - base2) / 2, 2) + Math.Pow(height, 2));
        }
    }
}