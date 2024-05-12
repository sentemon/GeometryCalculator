using System;

namespace Shapes
{
    // Cube class is a subclass of ThreeDimensionalShape class
    public class Cube : ThreeDimensionalShape
    {
        // Properties
        private double Side { get; set; }

        // Constructor
        public Cube(double side)
        {
            Side = side;
        }

        public override double Volume()
        {
            return Side * Side * Side;
        }

        public override double Area()
        {
            return 6 * Side * Side;
        }

        // CubeChosen method is called when the user chooses Cube
        public static void CubeChosen()
        {
            Console.WriteLine("Enter the side of the cube: ");
            try
            {
                double side = double.Parse(Console.ReadLine());
                Cube cube = new Cube(side);

                Console.WriteLine("Do you want to calculate the area or volume of the cube or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"\nThe area of the cube is {cube.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"\nThe volume of the cube is {cube.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"\nThe area of the cube is {cube.Area()}");
                    Console.WriteLine($"\nThe volume of the cube is {cube.Volume()}");
                }
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
                Console.WriteLine("Please enter a valid number.");
                CubeChosen();
            }
        }
    }
}