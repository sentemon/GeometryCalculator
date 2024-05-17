using System;
using GeometryCalculator;

namespace Shapes
{
    // Cylinder class is a subclass of ThreeDimensionalShape class
    public class Cylinder : ThreeDimensionalShape
    {
        // Properties
        public double Radius { get; set; }
        public double Height { get; set; }

        // Constructor
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double Volume()
        {
            return Math.PI * Radius * Radius * Height;
        }

        public override double Area()
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }

        // CylinderChosen method is called when the user chooses Cylinder
        public static void CylinderChosen()
        {
            try
            {
                string enterRadius = "Enter the radius of the cylinder: ";
                Features.WriteMessage(message: enterRadius);
                double radius = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the cylinder: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                Cylinder cylinder = new Cylinder(radius, height);

                string choiceMessage = "Do you want to calculate the area or volume of the cylinder or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the cylinder is {cylinder.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the cylinder is {cylinder.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the cylinder is {cylinder.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"\nThe volume of the cylinder is {cylinder.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "\nInvalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Error);

                    CylinderChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                CylinderChosen();
            }
        }
    }
}