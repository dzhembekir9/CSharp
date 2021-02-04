using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("type: ");
            string type = Console.ReadLine();
            double cost = 0;

            if (type == "Premiere")
            {
                cost = 12.00;
            }
            else if (type == "Normal")
            {
                cost = 7.50;
            }
            else if (type == "Discount")
            {
                cost = 5.00;
            }

            Console.Write("r = ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            double totalIncome = cost * r * c;

            Console.WriteLine("total income = {0:f2} leva", totalIncome);
        }
    }
}
