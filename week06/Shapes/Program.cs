using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 3);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}