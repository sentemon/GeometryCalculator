using System;

namespace Shapes
{
    // Square class is a subclass of TwoDimensionalShape class
    public class Square : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        // SquareChosen method is called when the user chooses Square
        public static void SquareChosen()
        {
            Console.WriteLine("Enter the side of the square: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Square square = new Square(side);

                Console.WriteLine("Do you want to calculate the area or perimeter of the square or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the square is {square.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the square is {square.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the square is {square.Area()}");
                    Console.WriteLine($"\nThe perimeter of the square is {square.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                SquareChosen();
            }
        }
    }
}