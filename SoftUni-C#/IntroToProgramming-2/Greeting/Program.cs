using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
