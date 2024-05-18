using System;
using GeometryCalculator;

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
            try
            {
                string enterBaseArea = "Enter the base area of the pyramid: ";
                Features.WriteMessage(message: enterBaseArea);
                double baseArea = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the pyramid: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                string enterSlantHeight = "Enter the slant height of the pyramid: ";
                Features.WriteMessage(message: enterSlantHeight);
                double slantHeight = double.Parse(Console.ReadLine());

                Pyramid pyramid = new Pyramid(baseArea, height, slantHeight);

                string choiceMessage = "Do you want to calculate the area or volume of the pyramid or both? (Area: a | Volume: v | Both: b)";
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the pyramid is {pyramid.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the pyramid is {pyramid.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the pyramid is {pyramid.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the pyramid is {pyramid.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    PyramidChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                PyramidChosen();
            }
        }
    }
}