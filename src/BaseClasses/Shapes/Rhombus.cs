using System;
using GeometryCalculator;

namespace Shapes
{
    // Rhombus class is a subclass of TwoDimensionalShape class
    public class Rhombus : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }
        private double Height { get; set; }

        // Constructor
        public Rhombus(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override double Area()
        {
            return Side * Height;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        // RhombusChosen method is called when the user chooses Rhombus
        public static void RhombusChosen()
        {
            try
            {
                string enterSide = "Enter the side of the rhombus: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the rhombus: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                Rhombus rhombus = new Rhombus(side, height);

                string choiceMessage = "Do you want to calculate the area or perimeter of the rhombus or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the rhombus is {rhombus.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the rhombus is {rhombus.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the rhombus is {rhombus.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the rhombus is {rhombus.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    RhombusChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                RhombusChosen();
            }
        }
    }
}