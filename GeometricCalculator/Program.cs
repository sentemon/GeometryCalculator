using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace GeometricCalculator
{
    internal class Program
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Geometric Calculator created by Sentemon");
        }
        public static void StartProgram()
        {
            Console.WriteLine("Choose a shape to calculate its properties: ");

            Features.ShowShapes();
            
            Console.Write("Enter the number of the shape: ");
            try 
            {
                int shapeNumber = int.Parse(Console.ReadLine());
                
                TryAgainWithTheSameShape:
                Features.ChooseShape(shapeNumber);
                if (Features.CheckContinue())
                {
                    Console.WriteLine("Do you want to calculate the property of another shape? (y/n)");
                    string choice = Console.ReadKey().Key.ToString().ToLower();

                    if (choice == "y")
                    {
                        Console.Clear();
                        StartProgram();
                    }
                    else
                    {
                        goto TryAgainWithTheSameShape;
                    }
                }

                else
                {
                    Console.WriteLine("Thx, goodbye");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                StartProgram();
            }
        }
        
        public static void Main(string[] args)
        {
            Console.Clear();
            Welcome();
            StartProgram();
        }
    }
}

