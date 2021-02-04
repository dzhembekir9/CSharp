using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("town: ");
            string town = Console.ReadLine();

            Console.Write("product: ");
            string product = Console.ReadLine();

            Console.Write("quantity = ");
            double quantity = double.Parse(Console.ReadLine());

            double sum = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    sum = quantity * 0.50;
                }
                else if (product == "water")
                {
                    sum = quantity * 0.80;
                }
                else if (product == "beer")
                {
                    sum = quantity * 1.20;
                }
                else if (product == "sweets")
                {
                    sum = quantity * 1.40;
                }
                else if (product == "peanuts")
                {
                    sum = quantity * 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    sum = quantity * 0.40;
                }
                else if (product == "water")
                {
                    sum = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    sum = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    sum = quantity * 1.30;
                }
                else if (product == "peanuts")
                {
                    sum = quantity * 1.50;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    sum = quantity * 0.45;
                }
                else if (product == "water")
                {
                    sum = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    sum = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    sum = quantity * 1.35;
                }
                else if (product == "peanuts")
                {
                    sum = quantity * 1.55;
                }
            }

            sum = Math.Round(sum, 4);
            Console.WriteLine(sum);
        }
    }
}
