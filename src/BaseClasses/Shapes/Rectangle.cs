using System;
using GeometryCalculator;

namespace Shapes
{
    // Rectangle class is a subclass of TwoDimensionalShape class
    public class Rectangle : TwoDimensionalShape
    {
        // Properties
        private double Length { get; set; }
        private double Width { get; set; }

        // Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }

        // RectangleChosen method is called when the user chooses Rectangle
        public static void RectangleChosen()
        {
            try
            {
                string enterLength = "Enter the length of the rectangle: ";
                Features.WriteMessage(message: enterLength);
                double length = double.Parse(Console.ReadLine());

                string enterWidth = "Enter the width of the rectangle: ";
                Features.WriteMessage(message: enterWidth);
                double width = double.Parse(Console.ReadLine());

                Rectangle rectangle = new Rectangle(length, width);

                string choiceMessage = "Do you want to calculate the area or perimeter of the rectangle or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the rectangle is {rectangle.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the rectangle is {rectangle.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the rectangle is {rectangle.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the rectangle is {rectangle.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    RectangleChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                RectangleChosen();
            }
        }
    }
}