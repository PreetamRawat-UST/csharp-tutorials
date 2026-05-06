using System;

// Base class
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class 1
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

// Derived class 2
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    // static void Main(string[] args)
    // {
    //     Animal a1 = new Dog();   // base reference, Dog object
    //     Animal a2 = new Cat();   // base reference, Cat object

    //     a1.Speak();  // Dog barks
    //     a2.Speak();  // Cat meows
    // }
}