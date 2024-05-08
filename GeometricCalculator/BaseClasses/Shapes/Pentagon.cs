using System;

namespace Shapes
{
    // Pentagon class is a subclass of TwoDimensionalShape class
    public class Pentagon : TwoDimensionalShape
    {
        // Constants
        private const double PentagonRatio = 1.720477401;

        // Properties
        public double Side { get; set; }

        // Constructor
        public Pentagon(double side)
        { 
            Side = side;
        }

        public override double Area()
        {
            return PentagonRatio * Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return 5 * Side;
        }

        // PentagonChosen method is called when the user chooses Pentagon
        public static void PentagonChosen()
        {
            Console.WriteLine("Enter the side of the pentagon: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Pentagon pentagon = new Pentagon(side);

                Console.WriteLine("Do you want to calculate the area or perimeter of the pentagon or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the pentagon is {pentagon.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the pentagon is {pentagon.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the pentagon is {pentagon.Area()}");
                    Console.WriteLine($"The perimeter of the pentagon is {pentagon.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                PentagonChosen();
            }
        }
    }
}