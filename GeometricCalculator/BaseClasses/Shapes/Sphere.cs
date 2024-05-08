using System;

namespace Shapes
{
    // Sphere class is a subclass of ThreeDimensionalShape class
    public class Sphere : ThreeDimensionalShape
    {
        private readonly double Radius;

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        }

        // SphereChosen method is called when the user chooses Sphere
        public static void SphereChosen()
        {
            Console.WriteLine("Enter the radius of the sphere: ");
            try
            {
                double radius = double.Parse(Console.ReadLine());
                Sphere sphere = new Sphere(radius);

                Console.WriteLine("Do you want to calculate the area or volume of the sphere or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the sphere is {sphere.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"The volume of the sphere is {sphere.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the sphere is {sphere.Area()}");
                    Console.WriteLine($"The volume of the sphere is {sphere.Volume()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                SphereChosen();
            }
        }
    }
}