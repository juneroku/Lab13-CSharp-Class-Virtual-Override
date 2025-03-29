using System;

public class Animal
{
    public string Name { get; set; }

    // Constructor ของคลาส Animal
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Animal Constructor: {Name}");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    // Constructor ของคลาส Dog ซึ่งเรียกใช้ Constructor ของ Animal
    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
        Console.WriteLine($"Dog Constructor: {Name}, {Breed}");
    }
}

class Program
{
    static void Main()
    {
        // สร้างออบเจกต์ Dog ที่ชื่อ "Buddy" และพันธุ์ "Golden Retriever"
        Dog dog = new Dog("Buddy", "Golden Retriever");
    }
}
