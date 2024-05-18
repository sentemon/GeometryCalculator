using System;
using GeometryCalculator;

namespace Shapes
{
    // Oval class is a subclass of TwoDimensionalShape class
    public class Oval : TwoDimensionalShape
    {
        private readonly double radius1;
        private readonly double radius2;

        public Oval(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }

        public override double Area()
        {
            return Math.PI * radius1 * radius2;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(radius1, 2) + Math.Pow(radius2, 2)) / 2);
        }

        // OvalChosen method is called when the user chooses Oval
        public static void OvalChosen()
        {
            try
            {
                string enterRadius1 = "Enter the radius1 of the oval: ";
                Features.WriteMessage(message: enterRadius1);
                double radius1 = double.Parse(Console.ReadLine());

                string enterRadius2 = "Enter the radius2 of the oval: ";
                Features.WriteMessage(message: enterRadius2);
                double radius2 = double.Parse(Console.ReadLine());

                Oval oval = new Oval(radius1, radius2);
                
                string choiceMessage = "Do you want to calculate the area or perimeter of the oval or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the oval is {oval.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the oval is {oval.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the oval is {oval.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the oval is {oval.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    OvalChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                OvalChosen();
            }
        }
    }
}