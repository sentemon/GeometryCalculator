using System;
using GeometryCalculator;

namespace Shapes
{
    // Sphere class is a subclass of ThreeDimensionalShape class
    public class Sphere : ThreeDimensionalShape
    {
        private readonly double Radius;

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        }

        // SphereChosen method is called when the user chooses Sphere
        public static void SphereChosen()
        {
            try
            {
                string enterRadius = "Enter the radius of the sphere: ";
                Features.WriteMessage(message: enterRadius);
                double radius = double.Parse(Console.ReadLine());

                Sphere sphere = new Sphere(radius);

                string choiceMessage = "Do you want to calculate the area or volume of the sphere or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the sphere is {sphere.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the sphere is {sphere.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the sphere is {sphere.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the sphere is {sphere.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "Invalid choice. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    SphereChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                SphereChosen();
            }
        }
    }
}