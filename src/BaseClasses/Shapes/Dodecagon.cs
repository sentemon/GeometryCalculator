using System;
using GeometryCalculator;

namespace Shapes
{
    // Dodecagon class is a subclass of TwoDimensionalShape class
    public class Dodecagon : TwoDimensionalShape
    {
        private readonly double SideLength;

        public Dodecagon(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(3) * SideLength * SideLength;
        }

        public override double Perimeter()
        {
            return 12 * SideLength;
        }

        // DodecagonChosen method is called when the user chooses Dodecagon
        public static void DodecagonChosen()
        {
            try
            {
                string enterSideLength = "Enter the side length of the dodecagon: ";
                Features.WriteMessage(message: enterSideLength);
                double sideLength = double.Parse(Console.ReadLine());

                Dodecagon dodecagon = new Dodecagon(sideLength);

                string choiceMessage = "Do you want to calculate the area or perimeter of the dodecagon or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the dodecagon is {dodecagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the dodecagon is {dodecagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the dodecagon is {dodecagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"\nThe perimeter of the dodecagon is {dodecagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    DodecagonChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                DodecagonChosen();
            }
        }
    }
}