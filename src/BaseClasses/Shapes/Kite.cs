using System;
using GeometryCalculator;

namespace Shapes
{
    // Kite class is a subclass of TwoDimensionalShape class
    public class Kite : TwoDimensionalShape
    {
        // Properties
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        // Constructor
        public Kite(double diagonal1, double diagonal2)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override double Area()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }

        public override double Perimeter()
        {
            return 2 * (Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2)));
        }

        // KiteChosen method is called when the user chooses Kite
        public static void KiteChosen()
        {
            try
            {
                string enterDiagonal1 = "Enter the first diagonal of the kite: ";
                Features.WriteMessage(message: enterDiagonal1);
                double diagonal1 = double.Parse(Console.ReadLine());

                string enterDiagonal2 = "Enter the second diagonal of the kite: ";
                Features.WriteMessage(message: enterDiagonal2);
                double diagonal2 = double.Parse(Console.ReadLine());

                Kite kite = new Kite(diagonal1, diagonal2);

                string choiceMessage = "Do you want to calculate the area or perimeter of the kite or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the kite is {kite.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the kite is {kite.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the kite is {kite.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string perimeterMessage = $"\nThe perimeter of the kite is {kite.Perimeter()}";
                    Features.WriteMessage(message: perimeterMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    KiteChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                KiteChosen();
            }
        }
    }
}