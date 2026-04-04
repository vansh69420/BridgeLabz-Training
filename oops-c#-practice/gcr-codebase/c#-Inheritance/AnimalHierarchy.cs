using System;

class Animal
{
    public string Name;
    public int Age;

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class Program
{
    static void Main()
    {
        Animal[] animals =
        {
            new Dog(),
            new Cat(),
            new Bird()
        };

        foreach (Animal a in animals)
        {
            a.MakeSound();   // Polymorphism
        }
    }
}
