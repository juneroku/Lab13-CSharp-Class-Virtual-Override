using System;
using System.Collections.Generic;

public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main()
    {
        // สร้าง List ของ Shape
        List<Shape> shapes = new List<Shape>();
        
        // เพิ่มออบเจกต์ของ Circle และ Rectangle ลงใน List
        shapes.Add(new Circle());
        shapes.Add(new Rectangle());
        shapes.Add(new Circle());

        // วาดรูปทุกชิ้นใน List
        foreach (Shape shape in shapes)
        {
            shape.Draw();  // เรียกใช้เมธอด Draw() ตามประเภทของออบเจกต์
        }
    }
}
