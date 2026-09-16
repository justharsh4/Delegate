using System;

class Program
{
    delegate void StudentResult(string name, int marks);

    static void DisplayDetails(string name, int marks)
    {
        Console.WriteLine("\nStudent Name: " + name);
        Console.WriteLine("Marks: " + marks);
    }

    static void CheckResult(string name, int marks)
    {
        if (marks >= 40)
            Console.WriteLine("Result: Passed");
        else
            Console.WriteLine("Result: Failed");
    }

    static void Main2()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Developer By Harsh Pachauri [26]");


        StudentResult result = DisplayDetails;
        result += CheckResult;

        result(name, marks);
    }
}