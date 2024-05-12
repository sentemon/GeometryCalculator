using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace GeometryCalculator
{
    internal class Features
    {
        private static Dictionary<int, string> shapes = new Dictionary<int, string>();

        /* 
            This method dynamically selects and invokes a method based on the provided shapeNumber.
            It retrieves the name of the shape class and constructs the method name to be invoked.
            Using reflection, it fetches the corresponding method and executes it if found.
            If the shape class or the method does not exist, appropriate error messages are printed.
        */
        public static void ChooseShape(int shapeNumber)
        {
            string className =  shapes[shapeNumber];
            string methodName = className + "Chosen";

            // Get the Type object for the shape class using reflection
            Type type = Type.GetType("Shapes." + className);

            // If the Type object is not null, the shape class exists
            if (type != null)
            {
                // Get the method information for the method to be invoked
                MethodInfo method = type.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public);
    
                // If the method exists, invoke it
                if (method != null)
                {
                    try
                    {
                        // Invoke the method on a null object instance since it's static
                        method.Invoke(null, null);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error invoking method: {e.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"{methodName} Method not found");
                }
            }
            else
            {
                Console.WriteLine($"{className} Class not found");
            }
        }

        
        /*
            This method prompts the user to continue or exit the program.
            It reads the user's choice and returns true if the user wants to continue, false otherwise.
        */
        public static bool CheckContinue()
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            string choice = Console.ReadKey().Key.ToString().ToLower();

            if (choice == "y")
                return true;

            return false;
        }

        // Actually, this method is not used in the program.
        /*
            This method writes a message character by character with a delay between each character.
            The speedDelay parameter specifies the delay between each character.
        */
        public static void WriteMessage(string message, int speedDelay = 25)
        {
            foreach (var c in message)
            {
                Console.Write(c);
                Task.Delay(speedDelay).Wait();
            }
            Console.WriteLine();
        }

        // all shapes names in dictionary
        public static void ShowShapes()
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Key}. {shape.Value}");
            }
        }

        // Write all shapes names in dictionary
        public static void WriteShapes()
        {
            string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "GeometryCalculator/Src/BaseClasses/Shapes");

            if (Directory.Exists(directoryPath))
            {
                string[] files = Directory.GetFiles(directoryPath);
                for (int i = 0; i < files.Length; i++)
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[i]);
                    shapes.Add(i + 1, fileNameWithoutExtension);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }

    }
}