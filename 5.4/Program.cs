using System;

interface IShape
{
    void Draw(int size);
}

class VerticalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
            Console.WriteLine("|");
    }
}

class HorizontalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
            Console.Write("-");
        Console.WriteLine();
    }
}

class Square : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                Console.Write("[]");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        IShape shape;

        shape = new VerticalLine();
        shape.Draw(5);

        shape = new HorizontalLine();
        shape.Draw(5);

        shape = new Square();
        shape.Draw(5);

        Console.ReadKey();
    }
}