using System;
using GeometryCalculator;

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
            try
            {
                string enterSide = "Enter the side of the cube: ";
                Features.WriteMessage(message: enterSide);
                double side = double.Parse(Console.ReadLine());

                Cube cube = new Cube(side);

                string choiceMessage = "Do you want to calculate the area or volume of the cube or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the cube is {cube.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the cube is {cube.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the cube is {cube.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the cube is {cube.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "\nInvalid input. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    CubeChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                CubeChosen();
            }
        }
    }
}