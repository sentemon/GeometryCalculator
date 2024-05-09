using System;

namespace Shapes
{
    // Dodecagon class is a subclass of TwoDimensionalShape class
    public class Dodecagon : TwoDimensionalShape
    {
        private readonly double SideLength;

        public Dodecagon(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(3) * SideLength * SideLength;
        }

        public override double Perimeter()
        {
            return 12 * SideLength;
        }

        // DodecagonChosen method is called when the user chooses Dodecagon
        public static void DodecagonChosen()
        {
            Console.WriteLine("Enter the side length of the dodecagon: ");
            try
            {
                double sideLength = double.Parse(Console.ReadLine());
                Dodecagon dodecagon = new Dodecagon(sideLength);

                Console.WriteLine("Do you want to calculate the area or perimeter of the dodecagon or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the dodecagon is {dodecagon.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the dodecagon is {dodecagon.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the dodecagon is {dodecagon.Area()}");
                    Console.WriteLine($"\nThe perimeter of the dodecagon is {dodecagon.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                DodecagonChosen();
            }
        }
    }
}