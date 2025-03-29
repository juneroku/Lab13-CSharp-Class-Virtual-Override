public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Shape shape1 = new Circle { Radius = 5 };
        Shape shape2 = new Rectangle { Width = 4, Height = 6 };

        Console.WriteLine($"Circle Area: {shape1.Area()}");
        Console.WriteLine($"Rectangle Area: {shape2.Area()}");
    }
}
