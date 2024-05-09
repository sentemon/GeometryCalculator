using System;

namespace Shapes
{
    // Cylinder class is a subclass of ThreeDimensionalShape class
    public class Cylinder : ThreeDimensionalShape
    {
        // Properties
        public double Radius { get; set; }
        public double Height { get; set; }

        // Constructor
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double Volume()
        {
            return Math.PI * Radius * Radius * Height;
        }

        public override double Area()
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }

        // CylinderChosen method is called when the user chooses Cylinder
        public static void CylinderChosen()
        {
            Console.WriteLine("Enter the radius of the cylinder: ");
            try
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the cylinder: ");
                double height = double.Parse(Console.ReadLine());
                Cylinder cylinder = new Cylinder(radius, height);

                Console.WriteLine("Do you want to calculate the area or volume of the cylinder or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the cylinder is {cylinder.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"\nThe volume of the cylinder is {cylinder.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the cylinder is {cylinder.Area()}");
                    Console.WriteLine($"\nThe volume of the cylinder is {cylinder.Volume()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                CylinderChosen();
            }
        }
    }
}