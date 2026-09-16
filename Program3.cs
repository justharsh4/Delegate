using System;

class Programm
{
    delegate void Calculator(int a, int b);

    static void Addition(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    static void Subtraction(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    static void Multiplication(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    static void Division(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Division = " + ((double)a / b));
        else
            Console.WriteLine("Cannot divide by zero");
    }

    static void Main3()
    {
        Console.Write("Enter first number: ");
        int a;

        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid input. Enter an integer: ");
        }

        Console.Write("Enter second number: ");
        int b;

        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Enter an integer: ");
        }
        Console.WriteLine("Developer By Harsh Pachauri [26]");

        Calculator calc = Addition;
        calc += Subtraction;
        calc += Multiplication;
        calc += Division;

        Console.WriteLine("\nResults:");
        calc(a, b);
    }
}