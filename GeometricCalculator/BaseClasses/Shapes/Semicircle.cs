using System;

namespace Shapes
{
    // Semicircle class is a subclass of TwoDimensionalShape class
    public class Semicircle : TwoDimensionalShape
    {
        private readonly double Radius;

        public Semicircle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2) / 2;
        }

        public override double Perimeter()
        {
            return Math.PI * Radius + 2 * Radius;
        }

        // SemicircleChosen method is called when the user chooses Semicircle
        public static void SemicircleChosen()
        {
            Console.WriteLine("Enter the radius of the semicircle: ");
            try
            {
                double radius = double.Parse(Console.ReadLine());
                Semicircle semicircle = new Semicircle(radius);

                Console.WriteLine("Do you want to calculate the area or perimeter of the semicircle or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the semicircle is {semicircle.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the semicircle is {semicircle.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the semicircle is {semicircle.Area()}");
                    Console.WriteLine($"\nThe perimeter of the semicircle is {semicircle.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                SemicircleChosen();
            }
        }
    }
}