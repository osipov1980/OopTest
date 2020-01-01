using System;
using System.Collections.Generic;

namespace OopTest
{
    class Program
    {
        static void Main(string[] args)
        {         
            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("1. Add new shape");
            Console.WriteLine("2. List all shapes");
            Console.WriteLine("3. Sum all circumferences");
            Console.WriteLine("4. Sum all areas");
            Console.WriteLine("5. Find biggest circumference");
            Console.WriteLine("6. Find biggest area");
            Console.WriteLine("7. Exit");

            ControlFunction(Console.ReadLine());
        }

        public static List<Shape> shapes = new List<Shape>();

        static void ControlFunction(string choice)
        {
            Console.Clear();
            string shapeTypeStr;          
            float[] shapeParameters = new float[2];            

            if (choice == "1") //Add new shape
            {
                shapeTypeStr = AddNewShapeMenu();
                shapeParameters = getParametersFromUser(shapeTypeStr);

                switch (shapeTypeStr)
                {
                    case "1":
                        shapes.Add(new Square(shapeParameters[0]));
                        break;
                    case "2":
                        shapes.Add(new Rectangle(shapeParameters[0], shapeParameters[1]));
                        break;
                    case "3":
                        shapes.Add(new Circle(shapeParameters[0]));
                        break;
                    case "4":
                        shapes.Add(new RightTriangle(shapeParameters[0], shapeParameters[1]));
                        break;
                }

                MainMenu();
            }
            else if (choice == "2") //ListAllShapes();
            {
                foreach (Shape shape in shapes)
                {
                    shape.PrintParameters();
                }
                Console.WriteLine("\n");
                MainMenu();
            }
            else if (choice == "3") //SumAllCircumferences();
            {
                float sumOfCircumferences = 0f;
                foreach (Shape shape in shapes)
                {
                    sumOfCircumferences += shape.Circumference();
                }
                Console.WriteLine("Sum of all Circumferences: " + sumOfCircumferences.ToString());
                Console.WriteLine("\n");
                MainMenu();
            }
            else if (choice == "4") //SumAllAreas();
            {
                float sumOfAreas = 0f;
                foreach (Shape shape in shapes)
                {
                    sumOfAreas += shape.Area();
                }
                Console.WriteLine("Sum of all Areas: " + sumOfAreas.ToString());
                Console.WriteLine("\n");
                MainMenu();
            }
            else if (choice == "5") //FindBiggestCircumference();
            {
                float biggestCircumference = 0f;
                int index = 0;
                int positionInList = 0;
                foreach (Shape shape in shapes)
                {
                    if(biggestCircumference < shape.Circumference());
                    {
                        biggestCircumference = shape.Circumference();
                        positionInList = index;
                    }
                    index++;
                }
                Console.WriteLine("Biggest Circumference is: " + biggestCircumference.ToString());
                shapes[positionInList].PrintParameters();
                Console.WriteLine("\n");
                MainMenu();
            }
            else if (choice == "6") //FindBiggestArea();
            {
                float biggestArea = 0f;
                int index = 0;
                int positionInList = 0;
                foreach (Shape shape in shapes)
                {
                    if (biggestArea < shape.Area()) ;
                    {
                        biggestArea = shape.Area();
                        positionInList = index;
                    }
                    index++;
                }
                Console.WriteLine("Biggest Area is: " + biggestArea.ToString());
                shapes[positionInList].PrintParameters();
                Console.WriteLine("\n");
                MainMenu();
            }
            else if (choice == "7") //Exit
            {
                Environment.Exit(0);
            }          
        }       

        static string AddNewShapeMenu()
        {
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Right triangle");

            string selectedShape = Console.ReadLine();
            Console.Clear();

            return selectedShape;
        }

        static float[] getParametersFromUser(string shapeTypeStr)
        {
            float[] parameters = new float[2];

            if (shapeTypeStr == "1") //Square
            {
                Console.WriteLine("Please, enter the width of Square and press Enter: ");
                parameters[0] = float.Parse(Console.ReadLine());
                Console.Clear();
            }
            else if (shapeTypeStr == "2") //Rectangle
            {
                Console.WriteLine("Please, enter the width of Rectangle and press Enter: ");
                parameters[0] = float.Parse(Console.ReadLine());
                Console.WriteLine("Please, enter the Height of Rectangle and press Enter: ");
                parameters[1] = float.Parse(Console.ReadLine());
                Console.Clear();
            }
            else if (shapeTypeStr == "3") //Circle
            {
                Console.WriteLine("Please, enter the radius of Circle and press Enter: ");
                parameters[0] = float.Parse(Console.ReadLine());
                Console.Clear();
            }
            else if (shapeTypeStr == "4") //Right triangle
            {
                Console.WriteLine("Please, enter the width of Right triangle and press Enter: ");
                parameters[0] = float.Parse(Console.ReadLine());
                Console.WriteLine("Please, enter the Height of Right triangle and press Enter: ");
                parameters[1] = float.Parse(Console.ReadLine());
                Console.Clear();
            }

            return parameters;
        }
    }
}
