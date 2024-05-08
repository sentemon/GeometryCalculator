using System;

namespace Shapes
{
    // Rhombus class is a subclass of TwoDimensionalShape class
    public class Rhombus : TwoDimensionalShape
    {
        // Properties
        private double Side { get; set; }
        private double Height { get; set; }

        // Constructor
        public Rhombus(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override double Area()
        {
            return Side * Height;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        // RhombusChosen method is called when the user chooses Rhombus
        public static void RhombusChosen()
        {
            Console.WriteLine("Enter the side of the rhombus: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the rhombus: ");
                double height = double.Parse(Console.ReadLine());
                Rhombus rhombus = new Rhombus(side, height);

                Console.WriteLine("Do you want to calculate the area or perimeter of the rhombus or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the rhombus is {rhombus.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the rhombus is {rhombus.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the rhombus is {rhombus.Area()}");
                    Console.WriteLine($"The perimeter of the rhombus is {rhombus.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                RhombusChosen();
            }
        }
    }
}