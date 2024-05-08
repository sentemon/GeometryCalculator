using System;

namespace Shapes
{
    // Cuboid class is a subclass of ThreeDimensionalShape class
    public class Cuboid : ThreeDimensionalShape
    {
        private readonly double Length;
        private readonly double Width;
        private readonly double Height;

        public Cuboid(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override double Volume()
        {
            return Length * Width * Height;
        }

        public override double Area()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        // CuboidChosen method is called when the user chooses Cuboid
        public static void CuboidChosen()
        {
            Console.WriteLine("Enter the length of the cuboid: ");
            try
            {
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the cuboid: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the cuboid: ");
                double height = double.Parse(Console.ReadLine());
                Cuboid cuboid = new Cuboid(length, width, height);

                Console.WriteLine("Do you want to calculate the area or volume of the cuboid or both? (Area: a | Volume: v | Both: b)");
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                    Console.WriteLine($"The area of the cuboid is {cuboid.Area()}");
                else if (choice == "v")
                    Console.WriteLine($"The volume of the cuboid is {cuboid.Volume()}");
                else if (choice == "b")
                {
                    Console.WriteLine($"The area of the cuboid is {cuboid.Area()}");
                    Console.WriteLine($"The volume of the cuboid is {cuboid.Volume()}");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                CuboidChosen();
            }
        }
    }
}