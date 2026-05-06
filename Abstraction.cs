using System;

abstract class Birds
{
    virtual public void Fly()
    {
        Console.WriteLine("Bird flies!");
    }

    public abstract void MakeSound();
}


class Parrot : Birds
{
    public override void MakeSound()
    {
        Console.WriteLine("Parrot makes a sound!");
    }
}
class Abstraction
{
    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Hello, World!");
    //     Birds parrotObj = new Parrot();
    //     parrotObj.Fly();
    //     parrotObj.MakeSound();
    // }
}