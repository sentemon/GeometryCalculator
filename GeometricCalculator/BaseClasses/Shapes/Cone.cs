using System;

namespace Shapes
{
    // Cone class is a subclass of ThreeDimensionalShape class
    public class Cone : ThreeDimensionalShape
    {
        // Properties
        public double Radius { get; set; }
        public double Height { get; set; }

        // Constructor
        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double Area()
        {
            return Math.PI * Radius * (Radius + Height);
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height / 3;
        }

        // ConeChosen method is called when the user chooses Cone
        public static void ConeChosen()
        {
            Console.WriteLine("Enter the radius of the cone: ");
            try
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the cone: ");
                double height = double.Parse(Console.ReadLine());
                Cone cone = new Cone(radius, height);

                Console.WriteLine("Do you want to calculate the area or volume of the cone or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the cone is {cone.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"The volume of the cone is {cone.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the cone is {cone.Area()}");
                    Console.WriteLine($"The volume of the cone is {cone.Volume()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                ConeChosen();
            }
        }
    }
}