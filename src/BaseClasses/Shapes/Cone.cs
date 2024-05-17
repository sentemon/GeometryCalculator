using System;
using GeometryCalculator;

namespace Shapes
{
    // Cone class is a subclass of ThreeDimensionalShape class
    public class Cone : ThreeDimensionalShape
    {
        // Properties
        public double Radius { get; set; }
        public double Height { get; set; }

        // Constructor
        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double Area()
        {
            return Math.PI * Radius * (Radius + Height);
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height / 3;
        }

        // ConeChosen method is called when the user chooses Cone
        public static void ConeChosen()
        {
            try
            {
                string enterRadius = "Enter the radius of the cone: ";
                Features.WriteMessage(message: enterRadius);
                double radius = double.Parse(Console.ReadLine());

                string enterHeight = "Enter the height of the cone: ";
                Features.WriteMessage(message: enterHeight);
                double height = double.Parse(Console.ReadLine());

                Cone cone = new Cone(radius, height);

                string choiceMessage = "Do you want to calculate the area or volume of the cone or both? (Area: a | Volume: v | Both: b)";
                Features.WriteMessage(message: choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the cone is {cone.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "v")
                {
                    string volumeMessage = $"\nThe volume of the cone is {cone.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the cone is {cone.Area()}";
                    Features.WriteMessage(message: areaMessage, colorMessage: ColorMessage.Success);

                    string volumeMessage = $"The volume of the cone is {cone.Volume()}";
                    Features.WriteMessage(message: volumeMessage, colorMessage: ColorMessage.Success);
                }
                else
                {
                    string invalidChoice = "\nInvalid input. Please enter a valid choice.";
                    Features.WriteMessage(message: invalidChoice, colorMessage: ColorMessage.Warning);

                    ConeChosen();
                }
            }
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(message: enterValidNumber);

                ConeChosen();
            }
        }
    }
}