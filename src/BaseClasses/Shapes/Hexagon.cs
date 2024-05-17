using System;
using GeometryCalculator;

namespace Shapes
{
    // Hexagon class is a subclass of TwoDimensionalShape class
    public class Hexagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Hexagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(3) * Math.Pow(Side, 2) / 2;
        }

        public override double Perimeter()
        {
            return 6 * Side;
        }

        // HexagonChosen method is called when the user chooses Hexagon
        public static void HexagonChosen()
        {
            try
            {
                string enterSide = "Enter the side of the hexagon: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Hexagon hexagon = new Hexagon(side);

                string choiceMessage = "Do you want to calculate the area or perimeter of the hexagon or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the hexagon is {hexagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the hexagon is {hexagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the hexagon is {hexagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"\nThe perimeter of the hexagon is {hexagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                HexagonChosen();
            }
        }
    }
}