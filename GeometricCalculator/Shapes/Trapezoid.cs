using System;

namespace Shapes
{
    // Trapezoid class is a subclass of TwoDimensionalShape class
    public class Trapezoid : TwoDimensionalShape
    {
        // Properties
        private double Base1 { get; set; }
        private double Base2 { get; set; }
        private double Height { get; set; }

        // Constructor
        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double Area()
        {
            return (Base1 + Base2) * Height / 2;
        }

        public override double Perimeter()
        {
            return Base1 + Base2 + 2 * Math.Sqrt(Math.Pow((Base1 - Base2) / 2, 2) + Math.Pow(Height, 2));
        }

        // TrapezoidChosen method is called when the user chooses Trapezoid
        public static void TrapezoidChosen()
        {
            Console.WriteLine("Enter the first base of the trapezoid: ");
            try
            {
                double base1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second base of the trapezoid: ");
                double base2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the trapezoid: ");
                double height = double.Parse(Console.ReadLine());
                Trapezoid trapezoid = new Trapezoid(base1, base2, height);

                Console.WriteLine("Do you want to calculate the area or perimeter of the trapezoid or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the trapezoid is {trapezoid.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the trapezoid is {trapezoid.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the trapezoid is {trapezoid.Area()}");
                    Console.WriteLine($"The perimeter of the trapezoid is {trapezoid.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                TrapezoidChosen();
            }
        }
    }
}