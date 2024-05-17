using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace GeometryCalculator
{
    internal class Run
    {
        public static void Welcome()
        {
            string welcomeMessage = "Welcome to Geometry Calculator created by Sentemon";
            Features.WriteMessage(message: welcomeMessage);
        }

        public static void StartProgram()
        {
            string chooseShape = "Choose a shape to calculate its properties: ";
            Features.WriteMessage(chooseShape);
            
            Features.ShowShapes();
            
            string enterNumberOfTheShape = "Enter the number of the shape: ";
            Features.WriteMessage(enterNumberOfTheShape);

            try 
            {
                int shapeNumber = int.Parse(Console.ReadLine());
                
                TryAgainWithTheSameShape:
                Features.ChooseShape(shapeNumber);

                if (Features.CheckContinue())
                {
                    string askForAnotherShape = "Do you want to calculate the property of another shape? (y/n)";
                    Features.WriteMessage(askForAnotherShape);

                    string choice = Console.ReadKey().Key.ToString().ToLower();

                    if (choice == "y")
                    {
                        Console.Clear();
                        StartProgram();
                    }
                    else
                    {
                        goto TryAgainWithTheSameShape; // I know this is not a good practice but I use it for my own purpose
                    }
                }

                else
                {
                    string thank = "\nThank you for using Geometric Calculator!";
                    Features.WriteMessage(message: thank, colorMessage: ColorMessage.Success);
                }
            }
            catch (Exception e)
            {
                string errorMessage = "Invalid input.\nAn error occurred: " + e.Message;
                Features.WriteMessage(message: errorMessage, colorMessage: ColorMessage.Error);

                string enterNumber = "Please enter a number.";
                Features.WriteMessage(message: enterNumber);
                
                StartProgram(); // Restart the program
            }
        }
    }
}

