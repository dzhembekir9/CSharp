using System;

namespace AnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("animal: ");
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog": Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
