using System;

namespace Area_of_Geometrical_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("type of figure: ");
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                Console.Write("length = ");
                double a = double.Parse(Console.ReadLine());

                double area = a * a;

                area = Math.Round(area, 3);
                Console.WriteLine("area = " + area);
            }
            else if (figureType == "rectangle")
            {
                Console.Write("length = ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("width = ");
                double width = double.Parse(Console.ReadLine());

                double area = width * length;

                area = Math.Round(area, 3);
                Console.WriteLine("area = " + area);

            }
            else if (figureType == "circle")
            {
                Console.Write("radius = ");
                double r = double.Parse(Console.ReadLine());

                double area = Math.PI * r * r;

                area = Math.Round(area, 3);
                Console.WriteLine("area = " + area);
            }
            else if (figureType == "triangle")
            {
                Console.Write("length = ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("h = ");
                double h = double.Parse(Console.ReadLine());

                double area = length * h / 2;

                area = Math.Round(area, 3);
                Console.WriteLine("area = " + area);
            }
        }
    }
}
