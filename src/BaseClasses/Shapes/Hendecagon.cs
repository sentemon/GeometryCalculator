using System;
using GeometryCalculator;

namespace Shapes
{
    // Hendecagon class is a subclass of TwoDimensionalShape class
    public class Hendecagon : TwoDimensionalShape
    {
        private readonly double SideLength;

        public Hendecagon(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area()
        {
            return 11 * SideLength * SideLength / (4 * Math.Tan(Math.PI / 11));
        }

        public override double Perimeter()
        {
            return 11 * SideLength;
        }

        // HendecagonChosen method is called when the user chooses Hendecagon
        public static void HendecagonChosen()
        {
            try
            {
                string enterSideLength = "Enter the side length of the hendecagon: ";
                Features.WriteMessage(message: enterSideLength);
                double sideLength = double.Parse(Console.ReadLine());

                Hendecagon hendecagon = new Hendecagon(sideLength);

                string choiceMessage = "Do you want to calculate the area or perimeter of the hendecagon or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the hendecagon is {hendecagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the hendecagon is {hendecagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the hendecagon is {hendecagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"\nThe perimeter of the hendecagon is {hendecagon.Perimeter()}";
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
                
                HendecagonChosen();
            }
        }
    }
}