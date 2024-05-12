using System;

namespace Shapes
{
    // Icosahedron class is a subclass of ThreeDimensionalShape class
    public class Icosahedron : ThreeDimensionalShape
    {
        private readonly double SideLength;

        public Icosahedron(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Volume()
        {
            return (5.0 / 12.0) * (3 + Math.Sqrt(5)) * Math.Pow(SideLength, 3);
        }

        public override double Area()
        {
            return 5 * Math.Sqrt(3) * Math.Pow(SideLength, 2);
        }

        // IcosahedronChosen method is called when the user chooses Icosahedron
        public static void IcosahedronChosen()
        {
            Console.WriteLine("Enter the side length of the icosahedron: ");
            try
            {
                double sideLength = double.Parse(Console.ReadLine());
                Icosahedron icosahedron = new Icosahedron(sideLength);

                Console.WriteLine("Do you want to calculate the area or volume of the icosahedron or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the icosahedron is {icosahedron.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"\nThe volume of the icosahedron is {icosahedron.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the icosahedron is {icosahedron.Area()}");
                    Console.WriteLine($"\nThe volume of the icosahedron is {icosahedron.Volume()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                IcosahedronChosen();
            }
        }
    }
}