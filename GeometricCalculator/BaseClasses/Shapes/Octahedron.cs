using System;

namespace Shapes
{
    // Octahedron class is a subclass of ThreeDimensionalShape class
    public class Octahedron : ThreeDimensionalShape
    {
        private readonly double Side;

        public Octahedron(double side)
        {
            Side = side;
        }

        public override double Volume()
        {
            return (Math.Sqrt(2) / 3) * Math.Pow(Side, 3);
        }

        public override double Area()
        {
            return 2 * Math.Sqrt(3) * Math.Pow(Side, 2);
        }

        // OctahedronChosen method is called when the user chooses Octahedron
        public static void OctahedronChosen()
        {
            Console.WriteLine("Enter the side of the octahedron: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Octahedron octahedron = new Octahedron(side);

                Console.WriteLine("Do you want to calculate the area or volume of the octahedron or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the octahedron is {octahedron.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"\nThe volume of the octahedron is {octahedron.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the octahedron is {octahedron.Area()}");
                    Console.WriteLine($"\nThe volume of the octahedron is {octahedron.Volume()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                OctahedronChosen();
            }
        }
    }
}