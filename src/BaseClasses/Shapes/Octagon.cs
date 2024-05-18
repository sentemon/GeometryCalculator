using System;
using GeometryCalculator;

namespace Shapes
{
    // Octagon class is a subclass of TwoDimensionalShape class
    public class Octagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Octagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return 8 * Side;
        }

        // OctagonChosen method is called when the user chooses Octagon
        public static void OctagonChosen()
        {
            try
            {
                string enterSide = "Enter the side of the octagon: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Octagon octagon = new Octagon(side);

                string choiceMessage = "Do you want to calculate the area or perimeter of the octagon or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the octagon is {octagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the octagon is {octagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the octagon is {octagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the octagon is {octagon.Perimeter()}";
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

                OctagonChosen();
            }
        }
    }
}