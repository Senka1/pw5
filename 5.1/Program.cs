using System;
using System.Collections.Generic;

interface IHello
{
    void SayHello();
}

class RussianHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Привет!");
    }
}

class EnglishHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class UkrainHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Прiвiт!");
    }
}

class PolishHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Cześć!");
    }
}

class ItalianHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Ciao!");
    }
}

class Program
{
    static void Main()
    {
        List<IHello> hellos = new List<IHello>()
        {
            new RussianHello(),
            new EnglishHello(),
            new UkrainHello(),
            new PolishHello(),
            new ItalianHello()
        };

        foreach (IHello hello in hellos)
        {
            Greet(hello);
        }

        Console.ReadKey();
    }

    static void Greet(IHello hello)
    {
        Console.Write("The greeting in your language is: ");
        hello.SayHello();
    }
}
