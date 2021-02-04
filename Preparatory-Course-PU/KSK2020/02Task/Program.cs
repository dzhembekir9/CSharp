using System;

namespace _02Task
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type coordinates for A");
        Console.Write("x1 = ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type coordinates for B");
        Console.Write("x2 = ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type coordinates for C");
        Console.Write("x3 = ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("y3 = ");
        double y3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type coordinates for P");
        Console.Write("x4 = ");
        double x4 = double.Parse(Console.ReadLine());
        Console.Write("y4 = ");
        double y4 = double.Parse(Console.ReadLine());
        if (x1 < x2 && x1 < x3 && x4 > x1)
            {
                if (y1 < y2 && y1 < y3 && y4 > y1)
                {
                    Console.WriteLine("P is in the triangle");
                }
                else if (y2 < y1 && y2 < y3 && y4 > y2)
                {
                    Console.WriteLine("P is in the triangle");
                }
                else if (y3 < y1 && y3 < y2 && y4 > y3)
                {
                    Console.WriteLine("P is in the triangle");
                }
            }
        else if (x2 < x1 && x2 < x3)
            {
                if (y1 < y2 && y1 < y3 && y4 > y1)
                {
                    Console.WriteLine("P is in the triangle");
                }
                else if (y2 < y1 && y2 < y3 && y4 > y2)
                {
                    Console.WriteLine("P is in the triangle");
                }
                else if (y3 < y1 && y3 < y2 && y4 > y3)
                {
                    Console.WriteLine("P is in the triangle");
                }
            }
            else if (x3 < x2 && x3 < x1)
            {
                if (y1 < y2 && y1 < y3 && y4 > y1)
                {
                    Console.WriteLine("P is in the triangle");
                }
                else if (y2 < y1 && y2 < y3 && y4 > y2)
                {
                    Console.WriteLine("P is in the triangle");
                }
                else if (y3 < y1 && y3 < y2 && y4 > y3)
                {
                    Console.WriteLine("P is in the triangle");
                }
            }
    }
}
}
