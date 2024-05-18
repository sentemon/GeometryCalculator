using System;
using GeometryCalculator;

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
            try
            {
                string enterSide = "Enter the side of the octahedron: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Octahedron octahedron = new Octahedron(side);

                string choiceMessage = "Do you want to calculate the area or volume of the octahedron or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the octahedron is {octahedron.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the octahedron is {octahedron.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the octahedron is {octahedron.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the octahedron is {octahedron.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    OctahedronChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                OctahedronChosen();
            }
        }
    }
}