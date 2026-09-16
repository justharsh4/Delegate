using System;

class Programe
{
    delegate int Calculator(int a, int b);

    static int Addition(int a, int b)
    {
        return a + b;
    }

    static int Subtraction(int a, int b)
    {
        return a - b;
    }

    static int Multiplication(int a, int b)
    {
        return a * b;
    }

    static int Division(int a, int b)
    {
        return a / b;
    }

    static void Main4()
    {
        int a, b;

        Console.Write("Enter first number: ");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Enter a valid integer: ");
        }

        Console.Write("Enter second number: ");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Enter a valid integer: ");
        }

        Calculator calc = Addition;
        calc += Subtraction;
        calc += Multiplication;
        calc += Division;

        Console.WriteLine("\nResults:");
        Console.WriteLine("Developer By Harsh Pachauri [26]");


        foreach (Calculator method in calc.GetInvocationList())
        {
            if (method.Method.Name == "Division" && b == 0)
            {
                Console.WriteLine("Division = Cannot divide by zero");
            }
            else
            {
                int result = method(a, b);
                Console.WriteLine(method.Method.Name + " = " + result);
            }
        }
    }
}