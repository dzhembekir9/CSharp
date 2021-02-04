using System;

 //Да се напише if-конструкция, която проверява стойността на две целочислени променливи и разменя техните стойности, ако стойността на първата променлива е по-голяма от втората.
class Program
{
  static void Main()
  {
    int n = 0;
    int i = 0;
    Console.Write("Type first number:" + " ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Type second number:" + " ");
    int number2 = int.Parse(Console.ReadLine());
    if (number1 > number2)
    {
      i = number2;
      n = number1;
      number1 = i;
      number2 = n;
    }
    Console.Write("First number is:" + " ");
    Console.WriteLine(number1);
    Console.Write("Second number is:" + " ");
    Console.WriteLine(number2);
  }
}

