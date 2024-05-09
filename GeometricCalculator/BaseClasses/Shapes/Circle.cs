using System;

namespace Shapes 
{
    // Circle class is a subclass of TwoDimensionalShape class
    public class Circle : TwoDimensionalShape
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        // IfCircle method is called when the user chooses Circle
        public static void CircleChosen()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            try
            {
                double radius = double.Parse(Console.ReadLine());
                Circle circle = new Circle(radius);

                Console.WriteLine("Do you want to calculate the area or perimeter of the circle or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the circle is {circle.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the circle is {circle.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the circle is {circle.Area()}");
                    Console.WriteLine($"\nThe perimeter of the circle is {circle.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                CircleChosen();
            }
        }
    }
}