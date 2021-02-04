using System;

namespace FruitVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("product: ");
            string product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("Fruit");
                    break;

                case "tomato":
                case "pepper":
                case "carrot":
                case "cucumber":
                    Console.WriteLine("Vegetable");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
