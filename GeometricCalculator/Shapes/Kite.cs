using System;

namespace Shapes
{
    // Kite class is a subclass of TwoDimensionalShape class
    public class Kite : TwoDimensionalShape
    {
        // Properties
        public double diagonal1 { get; set; }
        public double diagonal2 { get; set; }

        // Constructor
        public Kite(double diagonal1, double diagonal2)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public override double Area()
        {
            return (diagonal1 * diagonal2) / 2;
        }

        public override double Perimeter()
        {
            return 2 * (Math.Sqrt(Math.Pow(diagonal1 / 2, 2) + Math.Pow(diagonal2 / 2, 2)));
        }
    }
}