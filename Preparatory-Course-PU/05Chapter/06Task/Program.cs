using System;
// Напишете програма, която при въвеждане на коефициентите (a, b и c) на квадратно уравнение: ax2+bx+c, изчислява и извежда неговите реални корени (ако има такива). Квадратните уравнения могат да имат 0, 1 или 2 реални корена.
class Program
{
static void Main()
{
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("c = ");
    double c = double.Parse(Console.ReadLine());
    double d = (b * b) - (4 * a * c);
        if (d>0)
        {
            double d1=Math.Sqrt(d);
            double result1 = ((-b) + d1) / 2 * a;
            double result2 = ((-b) - d1) / 2 * a;
            Console.WriteLine("x1 = " + result1);
            Console.WriteLine("x2 = " + result2);

        }
        if (d<0)
        {
            Console.WriteLine("Няма реални корени");
        }
        if (d==0)
        {
            double result1 = (-b + Math.Sqrt(d)) / 2 * a;
            double result2 = (-b - Math.Sqrt(d)) / 2 * a;
            Console.WriteLine("x1 = "+result1);
            Console.WriteLine("x2 = " + result1*(-1));
        }
}
}   
