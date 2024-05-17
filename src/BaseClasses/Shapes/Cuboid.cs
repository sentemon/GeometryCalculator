using System;
using GeometryCalculator;

namespace Shapes
{
    // Cuboid class is a subclass of ThreeDimensionalShape class
    public class Cuboid : ThreeDimensionalShape
    {
        private readonly double Length;
        private readonly double Width;
        private readonly double Height;

        public Cuboid(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override double Volume()
        {
            return Length * Width * Height;
        }

        public override double Area()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        // CuboidChosen method is called when the user chooses Cuboid
        public static void CuboidChosen()
        {
            try
            {
                string enterLength = "Enter the length of the cuboid: ";
                Features.WriteMessage(message: enterLength);
                double length = double.Parse(Console.ReadLine());

                string enterWidth = "Enter the width of the cuboid: ";
                Features.WriteMessage(message: enterWidth);
                double width = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the cuboid: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                Cuboid cuboid = new Cuboid(length, width, height);

                string choiceMessage = "Do you want to calculate the area or volume of the cuboid or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the cuboid is {cuboid.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the cuboid is {cuboid.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the cuboid is {cuboid.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the cuboid is {cuboid.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    CuboidChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                CuboidChosen();
            }
        }
    }
}