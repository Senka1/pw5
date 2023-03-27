using System;
using System.Collections.Generic;

interface IAnimal
{
    void Voice();
}

class Frog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Ква!");
    }
}

class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав!");
    }
}

class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мяу!");
    }
}

class Ram : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мээ!");
    }
}

class Sparrow : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Чирик!");
    }
}

class Program
{
    static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>
        {
            new Frog(),
            new Dog(),
            new Cat(),
            new Ram(),
            new Sparrow()
        };

        foreach (IAnimal animal in animals)
        {
            PetAnimal(animal);
        }

        Console.ReadKey();
    }

    static void PetAnimal(IAnimal animal)
    {
        Console.WriteLine("Мы гладим зверушку, а она нам говорит:");
        animal.Voice();
    }
}