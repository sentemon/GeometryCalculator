using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace GeometricCalculator
{
    internal class Features
    {
        private static Dictionary<int, string> shapes = new Dictionary<int, string>();
        public static void ChooseShape(int shapeNumber)
        {
            switch (shapeNumber)
            {
                case 1:
                    Shapes.Circle.CircleChosen();
                    break;
                case 2:
                    Shapes.Pentagon.PentagonChosen();
                    break;
                case 3:
                    Shapes.Crescent.CrescentChosen();
                    break;
                case 4:
                    Shapes.Hexagon.HexagonChosen();
                    break;
                case 5:
                    Shapes.Icosahedron.IcosahedronChosen();
                    break;
                case 6:
                    Shapes.Oval.OvalChosen();
                    break;
                case 7:
                    Shapes.Rhombus.RhombusChosen();
                    break;
                case 8:
                    Shapes.Nonagon.NonagonChosen();
                    break;
                case 9:
                    Shapes.Hendecagon.HendecagonChosen();
                    break;
                case 10:
                    Shapes.Parallelogram.ParallelogramChosen();
                    break;
                case 11:
                    Shapes.Pyramid.PyramidChosen();
                    break;
                case 12:
                    Shapes.Trapezoid.TrapezoidChosen();
                    break;
                case 13:
                    Shapes.Square.SquareChosen();
                    break;
                case 14:
                    Shapes.Octagon.OctagonChosen();
                    break;
                case 15:
                    Shapes.Decagon.DecagonChosen();
                    break;
                case 16:
                    Shapes.Dodecahedron.DodecahedronChosen();
                    break;
                case 17:
                    Shapes.Kite.KiteChosen();
                    break;
                case 18:
                    Shapes.Cylinder.CylinderChosen();
                    break;
                case 19:
                    Shapes.Sphere.SphereChosen();
                    break;
                case 20:
                    Shapes.Semicircle.SemicircleChosen();
                    break;
                case 21:
                    Shapes.Octahedron.OctahedronChosen();
                    break;
                case 22:
                    Shapes.Cube.CubeChosen();
                    break;
                case 23:
                    Shapes.Dodecagon.DodecagonChosen();
                    break;
                case 24:
                    Console.WriteLine("need to fix");
                    break;
                case 25:
                    Shapes.Rectangle.RectangleChosen();
                    break;
                case 26:
                    Shapes.Cone.ConeChosen();
                    break;
                case 27:
                    Shapes.TriangularPrism.TriangularPrismChosen();
                    break;
                case 28:
                    Shapes.Triangle.TriangleChosen();
                    break;
                case 29:
                    Console.WriteLine("need to fix");
                    break;
                case 30:
                    Shapes.Cuboid.CuboidChosen();
                    break;
                case 31:
                    Console.WriteLine("need to fix");
                    break;
                case 32:
                    Shapes.PentagonalPrism.PentagonalPrismChosen();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    break;
            }
        }

        // it's not working but I will fix it
        // public static void ChooseShape(int shapeNumber)
        // {
        //     string className =  shapes[shapeNumber].GetType().Name;
        //     string methodName = shapes[shapeNumber] + "Chosen";
        //     Type type = Type.GetType("Shapes." + className);
        //     if (type != null)
        //     {
        //         MethodInfo method = type.GetMethod(methodName);
        //
        //         if (method != null)
        //         {
        //             object instance = Activator.CreateInstance(type);
        //
        //             method.Invoke(instance, null);
        //         }
        //         else
        //         {
        //             Console.WriteLine($"{methodName} Method not found");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{className} Class not found");
        //     }
        // }

        

        public static bool CheckContinue()
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            string choice = Console.ReadKey().Key.ToString().ToLower();

            if (choice == "y")
                return true;

            return false;
        }

        public static void WriteMessage(string message, int speedDelay = 50)
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
            string pathOfShapes = "/Users/mac/Desktop/GeometricCalculator/GeometricCalculator/BaseClasses/Shapes/";
            string[] shapesName = Directory.GetFiles(pathOfShapes);

            

            for (int i = 0; i < shapesName.Length; i++)
            {
                shapes.Add(i + 1, shapesName[i]
                    .Replace("/Users/mac/Desktop/GeometricCalculator/GeometricCalculator/BaseClasses/Shapes/", "")
                    .Replace(".cs", ""));
            }

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Key}. {shape.Value}");
            }
        }

    }
}