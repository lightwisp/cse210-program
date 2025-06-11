using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        Square s = new Square("Black", 7);
        Circle c = new Circle("Grey", 6);
        Rectangle r = new Rectangle("Green", 8, 4);
        shapes.AddRange([s, c, r]);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area for you {shape.GetName()} is {Math.Round(shape.GetArea(), 3)}");
        }
    }
}