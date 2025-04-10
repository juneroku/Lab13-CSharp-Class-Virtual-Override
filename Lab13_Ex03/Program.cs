﻿using System;

public class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class AnimalSound
{
    public void PlaySound(Animal animal)
    {
        animal.makeSound();
    }
}

class Program
{
    static void Main()
    {
        AnimalSound sound = new AnimalSound();
        Animal dog = new Dog();
        Animal cat = new Cat();

        sound.PlaySound(dog);  // จะพิมพ์ "Dog barks"
        sound.PlaySound(cat);  // จะพิมพ์ "Cat meows"
    }
}
