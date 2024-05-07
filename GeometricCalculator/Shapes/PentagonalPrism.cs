using System;

namespace Shapes
{
    // PentagonalPrism class is a subclass of ThreeDimensionalShape class
    public class PentagonalPrism : ThreeDimensionalShape
    {
        private readonly double SideLength;
        private readonly double Height;

        public PentagonalPrism(double sideLength, double height)
        {
            SideLength = sideLength;
            Height = height;
        }

        public override double Volume()
        {
            return 5 * SideLength * Height;
        }

        public override double Area()
        {
            return 5 * SideLength * SideLength + 5 * SideLength * Height;
        }

        // PentagonalPrismChosen method is called when the user chooses PentagonalPrism
        public static void PentagonalPrismChosen()
        {
            Console.WriteLine("Enter the side length of the pentagon: ");
            try
            {
                double sideLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the pentagonal prism: ");
                double height = double.Parse(Console.ReadLine());
                PentagonalPrism pentagonalPrism = new PentagonalPrism(sideLength, height);

                Console.WriteLine("Do you want to calculate the area or volume of the pentagonal prism or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the pentagonal prism is {pentagonalPrism.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"The volume of the pentagonal prism is {pentagonalPrism.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the pentagonal prism is {pentagonalPrism.Area()}");
                    Console.WriteLine($"The volume of the pentagonal prism is {pentagonalPrism.Volume()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                PentagonalPrismChosen();
            }
        }
    }
}