using System;

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
            Console.WriteLine("Enter the base side of the parallelogram: ");
            try
            {
                double baseSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the parallelogram: ");
                double height = double.Parse(Console.ReadLine());
                Parallelogram parallelogram = new Parallelogram(baseSide, height);

                Console.WriteLine("Do you want to calculate the area or perimeter of the parallelogram or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the parallelogram is {parallelogram.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the parallelogram is {parallelogram.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the parallelogram is {parallelogram.Area()}");
                    Console.WriteLine($"\nThe perimeter of the parallelogram is {parallelogram.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                ParallelogramChosen();
            }
        }
    }
}