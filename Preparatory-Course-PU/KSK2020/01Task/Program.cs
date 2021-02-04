using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter altitude (h): ");
        double h = double.Parse(Console.ReadLine());
        double area = (a * h) / 2;
        Console.WriteLine("The area is: {0}",area);

    }
}
