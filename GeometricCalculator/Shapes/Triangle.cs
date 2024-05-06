using System;

namespace Shapes
{
    // Triangle class is a subclass of TwoDimensionalShape class
    public class Triangle : TwoDimensionalShape
    {
        // Properties
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        // Constructor
        public Triangle(double b, double h, double s1, double s2, double s3)
        {
            Base = b;
            Height = h;
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}