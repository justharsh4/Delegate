using System;

class Programy
{
    delegate void TemperatureConverter(double celsius);

    static void CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }

    static void CelsiusToKelvin(double celsius)
    {
        double kelvin = celsius + 273.15;

        Console.WriteLine("Kelvin = " + kelvin);
    }

    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        TemperatureConverter converter = CelsiusToFahrenheit;
        converter += CelsiusToKelvin;

        Console.WriteLine("\nConverted Temperature:");
        converter(celsius);
        Console.WriteLine("Developer By Harsh Pachauri [26]");

    }
}