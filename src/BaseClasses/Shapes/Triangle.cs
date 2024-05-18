using System;
using GeometryCalculator;

namespace Shapes
{
    // Triangle class is a subclass of TwoDimensionalShape class
    public class Triangle : TwoDimensionalShape
    {
        // Properties
        private double Base { get; set; }
        private double Height { get; set; }
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }

        // Constructor
        public Triangle(double b, double h, double s1, double s2, double s3)
        {
            Base = b;
            Height = h;
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        // TriangleChosen method is called when the user chooses Triangle
        public static void TriangleChosen()
        {
            try
            {
                string enterBase = "Enter the base of the triangle: ";
                Features.WriteMessage(message: enterBase);
                double b = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the triangle: ";
                Features.WriteMessage(message: enterHeight);
                double h = double.Parse(Console.ReadLine());

                string enterSide1 = "Enter the first side of the triangle: ";
                Features.WriteMessage(message: enterSide1);
                double s1 = double.Parse(Console.ReadLine());

                string enterSide2 = "Enter the second side of the triangle: ";
                Features.WriteMessage(message: enterSide2);
                double s2 = double.Parse(Console.ReadLine());

                string enterSide3 = "Enter the third side of the triangle: ";
                Features.WriteMessage(message: enterSide3);
                double s3 = double.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(b, h, s1, s2, s3);

                string choiceMessage = "Do you want to calculate the area or perimeter of the triangle or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the triangle is {triangle.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the triangle is {triangle.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the triangle is {triangle.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the triangle is {triangle.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "\nInvalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    TriangleChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                TriangleChosen();
            }
        }
    }
}