using System;
using GeometryCalculator;

namespace Shapes
{
    // Semicircle class is a subclass of TwoDimensionalShape class
    public class Semicircle : TwoDimensionalShape
    {
        private readonly double Radius;

        public Semicircle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2) / 2;
        }

        public override double Perimeter()
        {
            return Math.PI * Radius + 2 * Radius;
        }

        // SemicircleChosen method is called when the user chooses Semicircle
        public static void SemicircleChosen()
        {
            try
            {
                string enterRadius = "Enter the radius of the semicircle: ";
                Features.WriteMessage(message: enterRadius);
                double radius = double.Parse(Console.ReadLine());

                Semicircle semicircle = new Semicircle(radius);

                string choiceMessage = "Do you want to calculate the area or perimeter of the semicircle or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the semicircle is {semicircle.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the semicircle is {semicircle.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the semicircle is {semicircle.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the semicircle is {semicircle.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);
                    SemicircleChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                SemicircleChosen();
            }
        }
    }
}