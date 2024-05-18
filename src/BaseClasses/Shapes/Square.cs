using System;
using GeometryCalculator;

namespace Shapes
{
    // Square class is a subclass of TwoDimensionalShape class
    public class Square : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        // SquareChosen method is called when the user chooses Square
        public static void SquareChosen()
        {
            try
            {
                string enterSide = "Enter the side of the square: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Square square = new Square(side);

                string choiceMessage = "Do you want to calculate the area or perimeter of the square or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the square is {square.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the square is {square.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the square is {square.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the square is {square.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    SquareChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                SquareChosen();
            }
        }
    }
}