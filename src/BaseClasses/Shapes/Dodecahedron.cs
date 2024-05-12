using System;

namespace Shapes
{
    // Dodecahedron class is a subclass of ThreeDimensionalShape class
    public class Dodecahedron : ThreeDimensionalShape
    {
        private readonly double EdgeLength;

        public Dodecahedron(double edgeLength)
        {
            EdgeLength = edgeLength;
        }

        public override double Volume()
        {
            return (15 + 7 * Math.Sqrt(5)) / 4 * Math.Pow(EdgeLength, 3);
        }

        public override double Area()
        {
            return 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * Math.Pow(EdgeLength, 2);
        }

        // DodecahedronChosen method is called when the user chooses Dodecahedron
        public static void DodecahedronChosen()
        {
            Console.WriteLine("Enter the edge length of the dodecahedron: ");
            try
            {
                double edgeLength = double.Parse(Console.ReadLine());
                Dodecahedron dodecahedron = new Dodecahedron(edgeLength);

                Console.WriteLine("Do you want to calculate the area or volume of the dodecahedron or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the dodecahedron is {dodecahedron.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"\nThe volume of the dodecahedron is {dodecahedron.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the dodecahedron is {dodecahedron.Area()}");
                    Console.WriteLine($"\nThe volume of the dodecahedron is {dodecahedron.Volume()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                DodecahedronChosen();
            }
        }
    }
}