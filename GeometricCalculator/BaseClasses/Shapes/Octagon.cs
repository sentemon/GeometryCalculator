using System;

namespace Shapes
{
    // Octagon class is a subclass of TwoDimensionalShape class
    public class Octagon : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Octagon(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return 8 * Side;
        }

        // OctagonChosen method is called when the user chooses Octagon
        public static void OctagonChosen()
        {
            Console.WriteLine("Enter the side of the octagon: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Octagon octagon = new Octagon(side);

                Console.WriteLine("Do you want to calculate the area or perimeter of the octagon or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the octagon is {octagon.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"\nThe perimeter of the octagon is {octagon.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the octagon is {octagon.Area()}");
                    Console.WriteLine($"\nThe perimeter of the octagon is {octagon.Perimeter()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                OctagonChosen();
            }
        }
    }
}