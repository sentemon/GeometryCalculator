using System;

namespace Shapes
{
    // Oval class is a subclass of TwoDimensionalShape class
    public class Oval : TwoDimensionalShape
    {
        private readonly double radius1;
        private readonly double radius2;

        public Oval(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }

        public override double Area()
        {
            return Math.PI * radius1 * radius2;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(radius1, 2) + Math.Pow(radius2, 2)) / 2);
        }

        // OvalChosen method is called when the user chooses Oval
        public static void OvalChosen()
        {
            Console.WriteLine("Enter the radius1 of the oval: ");
            try
            {
                double radius1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the radius2 of the oval: ");
                double radius2 = double.Parse(Console.ReadLine());
                Oval oval = new Oval(radius1, radius2);

                Console.WriteLine("Do you want to calculate the area or perimeter of the oval or both? (Area: a | Perimeter: p | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the oval is {oval.Area()}");
                else if (choice == "p")
                    Console.WriteLine($"The perimeter of the oval is {oval.Perimeter()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the oval is {oval.Area()}");
                    Console.WriteLine($"The perimeter of the oval is {oval.Perimeter()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                OvalChosen();
            }
        }
    }
}