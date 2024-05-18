using System;
using GeometryCalculator;

namespace Shapes
{
    // Pentagon class is a subclass of TwoDimensionalShape class
    public class Pentagon : TwoDimensionalShape
    {
        // Constants
        private const double PentagonRatio = 1.720477401;

        // Properties
        public double Side { get; set; }

        // Constructor
        public Pentagon(double side)
        { 
            Side = side;
        }

        public override double Area()
        {
            return PentagonRatio * Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return 5 * Side;
        }

        // PentagonChosen method is called when the user chooses Pentagon
        public static void PentagonChosen()
        {
            try
            {
                string enterSide = "Enter the side of the pentagon: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Pentagon pentagon = new Pentagon(side);

                string choiceMessage = "Do you want to calculate the area or perimeter of the pentagon or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the pentagon is {pentagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the pentagon is {pentagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the pentagon is {pentagon.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"The perimeter of the pentagon is {pentagon.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    PentagonChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
            
                PentagonChosen();
            }
        }
    }
}