using System;

namespace Shapes
{
    // Rectangle class is a subclass of TwoDimensionalShape class
    public class Rectangle : TwoDimensionalShape
    {
        // Properties
        private double Length { get; set; }
        private double Width { get; set; }

        // Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }

        // RectangleChosen method is called when the user chooses Rectangle
        public static void RectangleChosen()
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            try
            {
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(length, width);

                Console.WriteLine("Do you want to calculate the area or perimeter of the rectangle or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the rectangle is {rectangle.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the rectangle is {rectangle.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the rectangle is {rectangle.Area()}");
                    Console.WriteLine($"\nThe perimeter of the rectangle is {rectangle.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                RectangleChosen();
            }
        }
    }
}