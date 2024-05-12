using System;

namespace Shapes
{
    // Hendecagon class is a subclass of TwoDimensionalShape class
    public class Hendecagon : TwoDimensionalShape
    {
        private readonly double SideLength;

        public Hendecagon(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area()
        {
            return 11 * SideLength * SideLength / (4 * Math.Tan(Math.PI / 11));
        }

        public override double Perimeter()
        {
            return 11 * SideLength;
        }

        // HendecagonChosen method is called when the user chooses Hendecagon
        public static void HendecagonChosen()
        {
            Console.WriteLine("Enter the side length of the hendecagon: ");
            try
            {
                double sideLength = double.Parse(Console.ReadLine());
                Hendecagon hendecagon = new Hendecagon(sideLength);

                Console.WriteLine("Do you want to calculate the area or perimeter of the hendecagon or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the hendecagon is {hendecagon.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the hendecagon is {hendecagon.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the hendecagon is {hendecagon.Area()}");
                    Console.WriteLine($"\nThe perimeter of the hendecagon is {hendecagon.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                HendecagonChosen();
            }
        }
    }
}