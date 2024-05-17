using System;
using GeometryCalculator;

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
            try
            {
                string enterEdgeLength = "Enter the edge length of the dodecahedron: ";
                Features.WriteMessage(message: enterEdgeLength);
                double edgeLength = double.Parse(Console.ReadLine());

                Dodecahedron dodecahedron = new Dodecahedron(edgeLength);

                string choiceMessage = "Do you want to calculate the area or volume of the dodecahedron or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the dodecahedron is {dodecahedron.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the dodecahedron is {dodecahedron.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the dodecahedron is {dodecahedron.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the dodecahedron is {dodecahedron.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    DodecahedronChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);
                
                DodecahedronChosen();
            }
        }
    }
}