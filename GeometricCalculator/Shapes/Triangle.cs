using System;

namespace Shapes
{
    // Triangle class is a subclass of TwoDimensionalShape class
    public class Triangle : TwoDimensionalShape
    {
        // Properties
        private double Base { get; set; }
        private double Height { get; set; }
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }

        // Constructor
        public Triangle(double b, double h, double s1, double s2, double s3)
        {
            Base = b;
            Height = h;
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        // TriangleChosen method is called when the user chooses Triangle
        public static void TriangleChosen()
        {
            Console.WriteLine("Enter the base of the triangle: ");
            try
            {
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangle: ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first side of the triangle: ");
                double s1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second side of the triangle: ");
                double s2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third side of the triangle: ");
                double s3 = double.Parse(Console.ReadLine());
                Triangle triangle = new Triangle(b, h, s1, s2, s3);

                Console.WriteLine("Do you want to calculate the area or perimeter of the triangle or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the triangle is {triangle.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the triangle is {triangle.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the triangle is {triangle.Area()}");
                    Console.WriteLine($"The perimeter of the triangle is {triangle.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                TriangleChosen();
            }
        }
    }
}