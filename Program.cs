using System;


   abstract class Bird
    {
        public void Fly()

        {
        Console.WriteLine("Fly in sky");

        }
    public abstract void Colour();
    public abstract void Eat();

    }
class Parrot :Bird

{
    public override void Colour()
    {
        Console.WriteLine("Green");
    }

    public override void Eat()
    {
        Console.WriteLine("Chilly");
        Fgh();
    }
    public void Fgh()
    {
        Console.WriteLine("Hey");
    }
    static void Main (string[]args)
    {
        Bird obj = new Parrot();
        obj.Colour();
        obj.Eat();
        obj.Fly();

        Console.Read();

    }
}
