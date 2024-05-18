using System;
using GeometryCalculator;

namespace Shapes
{
    // TriangularPrism class is a subclass of ThreeDimensionalShape class
    public class TriangularPrism : ThreeDimensionalShape
    {
        private readonly double BaseSide;
        private readonly double Height;
        private readonly double Side1;
        private readonly double Side2;
        private readonly double Side3;

        public TriangularPrism(double baseSide, double height, double side1, double side2, double side3)
        {
            BaseSide = baseSide;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Volume()
        {
            return 0.5 * BaseSide * Height;
        }

        public override double Area()
        {
            return BaseSide + Side1 + Side2 + Side3;
        }

        // TriangularPrismChosen method is called when the user chooses TriangularPrism
        public static void TriangularPrismChosen()
        {
            try
            {
                string enterBaseSide = "Enter the base side of the triangular prism: ";
                Features.WriteMessage(message: enterBaseSide);
                double baseSide = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the triangular prism: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                string enterSide1 = "Enter the first side of the triangular prism: ";
                Features.WriteMessage(message: enterSide1);
                double side1 = double.Parse(Console.ReadLine());

                string enterSide2 = "Enter the second side of the triangular prism: ";
                Features.WriteMessage(message: enterSide2);
                double side2 = double.Parse(Console.ReadLine());

                string enterSide3 = "Enter the third side of the triangular prism: ";
                Features.WriteMessage(message: enterSide3);
                double side3 = double.Parse(Console.ReadLine());

                TriangularPrism triangularPrism = new TriangularPrism(baseSide, height, side1, side2, side3);

                string choiceMessage = "Do you want to calculate the area or volume of the triangular prism or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the triangular prism is {triangularPrism.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the triangular prism is {triangularPrism.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the triangular prism is {triangularPrism.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the triangular prism is {triangularPrism.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    TriangularPrismChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                TriangularPrismChosen();
            }
        }
    }
}