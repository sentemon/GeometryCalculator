using System;

namespace Shapes
{
    // Hexagon class is a subclass of TwoDimensionalShape class
    public class Hexagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Hexagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(3) * Math.Pow(Side, 2) / 2;
        }

        public override double Perimeter()
        {
            return 6 * Side;
        }

        // HexagonChosen method is called when the user chooses Hexagon
        public static void HexagonChosen()
        {
            Console.WriteLine("Enter the side of the hexagon: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Hexagon hexagon = new Hexagon(side);

                Console.WriteLine("Do you want to calculate the area or perimeter of the hexagon or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the hexagon is {hexagon.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the hexagon is {hexagon.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the hexagon is {hexagon.Area()}");
                    Console.WriteLine($"The perimeter of the hexagon is {hexagon.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                HexagonChosen();
            }
        }
    }
}