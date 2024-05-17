using System;
using GeometryCalculator;

namespace Shapes
{
    // Decagon class is a subclass of TwoDimensionalShape class
    public class Decagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Decagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return 2.5 * Side * Side * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }

        public override double Perimeter()
        {
            return 10 * Side;
        }

        // DecagonChosen method is called when the user chooses Decagon
        public static void DecagonChosen()
        {
            try
            {
                string enterSide = "Enter the side of the decagon: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Decagon decagon = new Decagon(side);

                string choiceMessage = "Do you want to calculate the area or perimeter of the decagon or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the decagon is {decagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the decagon is {decagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the decagon is {decagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                    
                    string perimeterMessage = $"\nThe perimeter of the decagon is {decagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "\nInvalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice);

                    DecagonChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                DecagonChosen();
            }
        }
    }
}