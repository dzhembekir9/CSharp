using System;
// Напишете програма, която показва знака (+ или -) от произведението на три реални числа, без да го пресмята. Използвайте последователност от if оператори.
class Program
{
  static void Main()
  {
    Console.Write("Type first number:"+" ");
    double number1 = double.Parse(Console.ReadLine());
    Console.Write("Type second number:"+ " " );
    double number2 = double.Parse(Console.ReadLine());
    Console.Write("Type third number:"+" ");
    double number3 = double.Parse(Console.ReadLine());
    double result = number1 * number2 * number3;
    if (result < 0)
    {
      Console.WriteLine("-");
    }
    else
    {
      Console.WriteLine("+");
    }
  }
}

