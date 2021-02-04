using System;

namespace Greeting1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first name: ");
            string firstName = Console.ReadLine();

            Console.Write("last name: ");
            string lastName = Console.ReadLine();

            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("town: ");
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-old person from {town}.");
        }
    }
}
