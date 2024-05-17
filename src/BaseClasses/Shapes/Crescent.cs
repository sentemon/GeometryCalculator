using System;
using GeometryCalculator;

namespace Shapes
{
    // Crescent class is a subclass of TwoDimensionalShape class
    public class Crescent : TwoDimensionalShape
    {
        private readonly double Radius1;
        private readonly double Radius2;

        public Crescent(double radius1, double radius2)
        {
            Radius1 = radius1;
            Radius2 = radius2;
        }

        public override double Area()
        {
            return Math.PI * (Radius1 * Radius1 - Radius2 * Radius2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius1;
        }

        // CrescentChosen method is called when the user chooses Crescent
        public static void CrescentChosen()
        {
            try
            {
                string enterRadius1 = "Enter the radius1 of the crescent: ";
                Features.WriteMessage(message: enterRadius1);
                double radius1 = double.Parse(Console.ReadLine());

                string enterRadius2 = "Enter the radius2 of the crescent: ";
                Features.WriteMessage(message: enterRadius2);
                double radius2 = double.Parse(Console.ReadLine());

                Crescent crescent = new Crescent(radius1, radius2);

                string choiceMessage = "Do you want to calculate the area or perimeter of the crescent or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the crescent is {crescent.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"The perimeter of the crescent is {crescent.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the crescent is {crescent.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the crescent is {crescent.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "\nInvalid input. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    CrescentChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                CrescentChosen();
            }
        }
    }
}