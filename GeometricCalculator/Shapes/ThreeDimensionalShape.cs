using System;

namespace Shapes
{
    // ThreeDimensionalShape class is an abstract class that has an abstract method Volume
    public abstract class ThreeDimensionalShape : Shape
    {
        public abstract double Volume();
    }
}