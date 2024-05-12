using System;

namespace Shapes
{
    // TwoDimensionalShape class is an abstract class that has two abstract methods Area and Perimeter
    public abstract class TwoDimensionalShape : Shape
    { 
        public abstract double Perimeter();
    }
}