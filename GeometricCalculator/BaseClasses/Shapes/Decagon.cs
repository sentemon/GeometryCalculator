using System;

namespace Shapes
{
    // Decagon class is a subclass of TwoDimensionalShape class
    public class Decagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Decagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return 2.5 * Side * Side * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }

        public override double Perimeter()
        {
            return 10 * Side;
        }

        // DecagonChosen method is called when the user chooses Decagon
        public static void DecagonChosen()
        {
            Console.WriteLine("Enter the side of the decagon: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Decagon decagon = new Decagon(side);

                Console.WriteLine(
                    "Do you want to calculate the area or perimeter of the decagon or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the decagon is {decagon.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the decagon is {decagon.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the decagon is {decagon.Area()}");
                    Console.WriteLine($"The perimeter of the decagon is {decagon.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                DecagonChosen();
            }
        }
    }
}