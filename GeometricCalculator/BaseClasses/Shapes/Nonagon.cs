using System;

namespace Shapes
{
    // Nonagon class is a subclass of TwoDimensionalShape class
    public class Nonagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Nonagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return (9 * Math.Pow(Side, 2)) / (4 * Math.Tan(Math.PI / 9));
        }

        public override double Perimeter()
        {
            return 9 * Side;
        }

        // NonagonChosen method is called when the user chooses Nonagon
        public static void NonagonChosen()
        {
            Console.WriteLine("Enter the side of the nonagon: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Nonagon nonagon = new Nonagon(side);

                Console.WriteLine("Do you want to calculate the area or perimeter of the nonagon or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the nonagon is {nonagon.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the nonagon is {nonagon.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the nonagon is {nonagon.Area()}");
                    Console.WriteLine($"The perimeter of the nonagon is {nonagon.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                NonagonChosen();
            }
        }
    }
}