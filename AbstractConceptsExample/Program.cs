using AbstractConceptsExample.Entities;
using AbstractConceptsExample.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractConceptsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();

            
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color;
                Enum.TryParse<Color>(Console.ReadLine(), out color);

                if (type == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapeList.Add(new Rectangle(color, width, height));
                }
                else if (type == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapeList.Add(new Circle(color, radius));
                }
                else
                    Console.WriteLine("Shape not identified!");

            }


            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine($"{shape.Area():f2}");
            }



            Console.ReadKey();
        }
    }
}
