using System;

class Program1
{
    delegate void CalculateSum(int a, int b);

    static void Sum(int a, int b)
    {
        Console.WriteLine("Sum = " + (a + b));
    }

    static void Main1()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Developer By Harsh Pachauri [26]");

        CalculateSum obj = Sum;

        obj(a, b);
    }
}