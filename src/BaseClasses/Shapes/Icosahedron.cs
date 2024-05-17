using System;
using GeometryCalculator;

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
            try
            {
                string enterSideLength = "Enter the side length of the icosahedron: ";
                Features.WriteMessage(message: enterSideLength);
                double sideLength = double.Parse(Console.ReadLine());

                Icosahedron icosahedron = new Icosahedron(sideLength);

                string choiceMessage = "Do you want to calculate the area or volume of the icosahedron or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the icosahedron is {icosahedron.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the icosahedron is {icosahedron.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the icosahedron is {icosahedron.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the icosahedron is {icosahedron.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    IcosahedronChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                IcosahedronChosen();
            }
        }
    }
}