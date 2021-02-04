using System;

namespace Same_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first word: ");
            string word1 = Console.ReadLine();

            Console.Write("second word: ");
            string word2 = Console.ReadLine();

            word1 = word1.ToLower();
            word2 = word2.ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
