using System;
using GeometryCalculator;

namespace Shapes
{
    // Trapezoid class is a subclass of TwoDimensionalShape class
    public class Trapezoid : TwoDimensionalShape
    {
        // Properties
        private double Base1 { get; set; }
        private double Base2 { get; set; }
        private double Height { get; set; }

        // Constructor
        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double Area()
        {
            return (Base1 + Base2) * Height / 2;
        }

        public override double Perimeter()
        {
            return Base1 + Base2 + 2 * Math.Sqrt(Math.Pow((Base1 - Base2) / 2, 2) + Math.Pow(Height, 2));
        }

        // TrapezoidChosen method is called when the user chooses Trapezoid
        public static void TrapezoidChosen()
        {
            try
            {
                string enterBase1 = "Enter the first base of the trapezoid: ";
                Features.WriteMessage(message: enterBase1);
                double base1 = double.Parse(Console.ReadLine());

                string enterBase2 = "Enter the second base of the trapezoid: ";
                Features.WriteMessage(message: enterBase2);
                double base2 = double.Parse(Console.ReadLine());    

                string enterHeight = "Enter the height of the trapezoid: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                Trapezoid trapezoid = new Trapezoid(base1, base2, height);

                string choiceMessage = "Do you want to calculate the area or perimeter of the trapezoid or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the trapezoid is {trapezoid.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the trapezoid is {trapezoid.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the trapezoid is {trapezoid.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the trapezoid is {trapezoid.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    TrapezoidChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                TrapezoidChosen();
            }
        }
    }
}