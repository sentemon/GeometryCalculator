using System;
using GeometryCalculator;

namespace Shapes
{
    // Parallelogram class is a subclass of TwoDimensionalShape class
    public class Parallelogram : TwoDimensionalShape
    {
        // Properties
        private double BaseSide { get; set; }
        private double Height { get; set; }

        // Constructor
        public Parallelogram(double baseSide, double height)
        {
            BaseSide = baseSide;
            Height = height;
        }

        public override double Area()
        {
            return BaseSide * Height;
        }

        public override double Perimeter()
        {
            return 2 * (BaseSide + Height);
        }

        // ParallelogramChosen method is called when the user chooses Parallelogram
        public static void ParallelogramChosen()
        {
            try
            {
                string enterBaseSide = "Enter the base side of the parallelogram: ";
                Features.WriteMessage(message: enterBaseSide);
                double baseSide = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the parallelogram: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                Parallelogram parallelogram = new Parallelogram(baseSide, height);

                string choiceMessage = "Do you want to calculate the area or perimeter of the parallelogram or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the parallelogram is {parallelogram.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the parallelogram is {parallelogram.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the parallelogram is {parallelogram.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the parallelogram is {parallelogram.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    ParallelogramChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                ParallelogramChosen();
            }
        }
    }
}