using System;
// Да се напише програма, с която при въвеждане на стойностите за три страни на триъгълник, се извежда от конзолата дали триъгълникът е равностранен, равнобедрен или правоъгълен!

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля, въведете а, b и c");
        Console.Write("a = "); 
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a == b && b == c)
        {
            Console.WriteLine("Триъгълникът е равностранен");
        }
        if ((a == b) && a !=c)
        {
            Console.WriteLine("Триъгълникът е равнобедрен");
        }
        if ((a == c) && a != b)
        {
            Console.WriteLine("Триъгълникът е равнобедрен");
        }
        if ((b == c) && b != a)
        {
            Console.WriteLine("Триъгълникът е равнобедрен");
        }
        if ((a * a) + (b * b) == c * c)
        {
            Console.WriteLine("Триъгълникът е правоъгълен");
        }
        if ((a * a) + (c * c) == b * b)
        {
            Console.WriteLine("Триъгълникът е правоъгълен");
        }
        if ((b * b) + (c * c) == a * a)
        {
            Console.WriteLine("Триъгълникът е правоъгълен");
        }

    }
}

