using System;
using GeometryCalculator;

namespace Shapes
{
    // PentagonalPrism class is a subclass of ThreeDimensionalShape class
    public class PentagonalPrism : ThreeDimensionalShape
    {
        private readonly double SideLength;
        private readonly double Height;

        public PentagonalPrism(double sideLength, double height)
        {
            SideLength = sideLength;
            Height = height;
        }

        public override double Volume()
        {
            return 5 * SideLength * Height;
        }

        public override double Area()
        {
            return 5 * SideLength * SideLength + 5 * SideLength * Height;
        }

        // PentagonalPrismChosen method is called when the user chooses PentagonalPrism
        public static void PentagonalPrismChosen()
        {
            try
            {
                string enterSideLength = "Enter the side length of the pentagonal prism: ";
                Features.WriteMessage(message: enterSideLength);
                double sideLength = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the pentagonal prism: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                PentagonalPrism pentagonalPrism = new PentagonalPrism(sideLength, height);

                string choiceMessage = "Do you want to calculate the area or volume of the pentagonal prism or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the pentagonal prism is {pentagonalPrism.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the pentagonal prism is {pentagonalPrism.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the pentagonal prism is {pentagonalPrism.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the pentagonal prism is {pentagonalPrism.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    PentagonalPrismChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                PentagonalPrismChosen();
            }
        }
    }
}