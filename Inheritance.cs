using System;

class Vehicle
{
    virtual public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}

class Car : Vehicle
{
    public override void Honk()
    {
        Console.WriteLine("Car  honk!");
    }
}
class MainClass
{
    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Hello, World!");
    //     Vehicle carObj = new Car();
    //     carObj.Honk();
    // }
}