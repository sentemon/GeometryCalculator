using System;

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
            Console.WriteLine("Enter the first diagonal of the kite: ");
            try
            {
                double diagonal1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second diagonal of the kite: ");
                double diagonal2 = double.Parse(Console.ReadLine());
                Kite kite = new Kite(diagonal1, diagonal2);

                Console.WriteLine("Do you want to calculate the area or perimeter of the kite or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the kite is {kite.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the kite is {kite.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the kite is {kite.Area()}");
                    Console.WriteLine($"The perimeter of the kite is {kite.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                KiteChosen();
            }
        }
    }
}