using System;
using GeometryCalculator;

namespace Shapes
{
    // Nonagon class is a subclass of TwoDimensionalShape class
    public class Nonagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Nonagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return (9 * Math.Pow(Side, 2)) / (4 * Math.Tan(Math.PI / 9));
        }

        public override double Perimeter()
        {
            return 9 * Side;
        }

        // NonagonChosen method is called when the user chooses Nonagon
        public static void NonagonChosen()
        {
            try
            {
                string enterSide = "Enter the side of the nonagon: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Nonagon nonagon = new Nonagon(side);

                string choiceMessage = "Do you want to calculate the area or perimeter of the nonagon or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the nonagon is {nonagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the nonagon is {nonagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);   
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the nonagon is {nonagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                    
                    string perimeterMessage = $"\nThe perimeter of the nonagon is {nonagon.Perimeter()}";
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

                NonagonChosen();
            }
        }
    }
}