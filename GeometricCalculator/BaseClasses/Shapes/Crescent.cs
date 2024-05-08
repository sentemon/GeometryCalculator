using System;

namespace Shapes
{
    // Crescent class is a subclass of TwoDimensionalShape class
    public class Crescent : TwoDimensionalShape
    {
        private readonly double Radius1;
        private readonly double Radius2;

        public Crescent(double radius1, double radius2)
        {
            Radius1 = radius1;
            Radius2 = radius2;
        }

        public override double Area()
        {
            return Math.PI * (Radius1 * Radius1 - Radius2 * Radius2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius1;
        }

        // CrescentChosen method is called when the user chooses Crescent
        public static void CrescentChosen()
        {
            Console.WriteLine("Enter the radius1 of the crescent: ");
            try
            {
                double radius1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the radius2 of the crescent: ");
                double radius2 = double.Parse(Console.ReadLine());
                Crescent crescent = new Crescent(radius1, radius2);

                Console.WriteLine(
                    "Do you want to calculate the area or perimeter of the crescent or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the crescent is {crescent.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the crescent is {crescent.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the crescent is {crescent.Area()}");
                    Console.WriteLine($"The perimeter of the crescent is {crescent.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                CrescentChosen();
            }
        }
    }
}