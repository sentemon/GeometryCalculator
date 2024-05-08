using System;

namespace Shapes
{
    // TriangularPrism class is a subclass of ThreeDimensionalShape class
    public class TriangularPrism : ThreeDimensionalShape
    {
        private readonly double BaseSide;
        private readonly double Height;
        private readonly double Side1;
        private readonly double Side2;
        private readonly double Side3;

        public TriangularPrism(double baseSide, double height, double side1, double side2, double side3)
        {
            BaseSide = baseSide;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Volume()
        {
            return 0.5 * BaseSide * Height;
        }

        public override double Area()
        {
            return BaseSide + Side1 + Side2 + Side3;
        }

        // TriangularPrismChosen method is called when the user chooses TriangularPrism
        public static void TriangularPrismChosen()
        {
            Console.WriteLine("Enter the base side of the triangular prism: ");
            try
            {
                double baseSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangular prism: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first side of the triangular prism: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second side of the triangular prism: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third side of the triangular prism: ");
                double side3 = double.Parse(Console.ReadLine());
                TriangularPrism triangularPrism = new TriangularPrism(baseSide, height, side1, side2, side3);

                Console.WriteLine("Do you want to calculate the area or volume of the triangular prism or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the triangular prism is {triangularPrism.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"The volume of the triangular prism is {triangularPrism.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the triangular prism is {triangularPrism.Area()}");
                    Console.WriteLine($"The volume of the triangular prism is {triangularPrism.Volume()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                TriangularPrismChosen();
            }
        }
    }
}