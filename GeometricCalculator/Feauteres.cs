using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeometricCalculator
{
    internal class Features
    {
        // Show all shapes in the Shapes folder but it's working only for me because the path is hardcoded and I don't know how to make it work for everyone
        public static void ShowShapes()
        {
            string pathOfShapes = @"/Users/mac/Desktop/GeometricCalculator/GeometricCalculator/Shapes";
            
            string[] shapesName = Directory.GetFiles(pathOfShapes);

            for (int i = 0; i < shapesName.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {shapesName[i]
                    .Replace("/Users/mac/Desktop/GeometricCalculator/GeometricCalculator/Shapes/", "")
                    .Replace(".cs", "")}");
            }
        }

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

        public static bool CheckContinue()
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            string choice = Console.ReadKey().Key.ToString().ToLower();

            if (choice == "y")
                return true;

            return false;
        }

    }
}