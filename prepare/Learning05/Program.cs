using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // Iterate through the list and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}