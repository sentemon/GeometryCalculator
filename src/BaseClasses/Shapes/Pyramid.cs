using System;

namespace Shapes
{
    // Pyramid class is a subclass of ThreeDimensionalShape class
    public class Pyramid : ThreeDimensionalShape
    {
        private readonly double BaseArea;
        private readonly double Height;
        private readonly double SlantHeight;

        public Pyramid(double baseArea, double height, double slantHeight)
        {
            BaseArea = baseArea;
            Height = height;
            SlantHeight = slantHeight;
        }

        public override double Volume()
        {
            return (BaseArea * Height) / 3;
        }

        public override double Area()
        {
            double lateralArea = (Perimeter() * SlantHeight) / 2;
            return BaseArea + lateralArea;
        }

        private double Perimeter()
        {
            // For a regular polygonal base, perimeter = number of sides * side length
            // need to provide this method based on implementation
            // For demonstration purposes, assuming a square base
            int numberOfSides = 4;
            double sideLength = Math.Sqrt(BaseArea);
            
            return numberOfSides * sideLength;
        }

        // PyramidChosen method is called when the user chooses Pyramid
        public static void PyramidChosen()
        {
            Console.WriteLine("Enter the base area of the pyramid: ");
            try
            {
                double baseArea = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the pyramid: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the slant height of the pyramid: ");
                double slantHeight = double.Parse(Console.ReadLine());
                Pyramid pyramid = new Pyramid(baseArea, height, slantHeight);

                Console.WriteLine("Do you want to calculate the area or volume of the pyramid or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the pyramid is {pyramid.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"\nThe volume of the pyramid is {pyramid.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the pyramid is {pyramid.Area()}");
                    Console.WriteLine($"\nThe volume of the pyramid is {pyramid.Volume()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                PyramidChosen();
            }
        }
    }
}