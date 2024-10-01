using System;

namespace operationsApplication
{
    
    public class TemperatureConverter
    {
        // Converts Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Converts Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    public class PerformTemperatureConversion
    {
        // Method to handle user interaction and perform conversion
        public void StartConversion()
        {
            Console.WriteLine("Temperature Conversion App");
            Console.WriteLine("Choose the type of conversion:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            string choice = Console.ReadLine();
            double inputTemperature = 0;
            double result = 0;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter temperature in Celsius:");
                    inputTemperature = Convert.ToDouble(Console.ReadLine());
                    result = TemperatureConverter.CelsiusToFahrenheit(inputTemperature);
                    Console.WriteLine($"{inputTemperature} °C is {result} °F");
                    break;

                case "2":
                    Console.WriteLine("Enter temperature in Fahrenheit:");
                    inputTemperature = Convert.ToDouble(Console.ReadLine());
                    result = TemperatureConverter.FahrenheitToCelsius(inputTemperature);
                    Console.WriteLine($"{inputTemperature} °F is {result} °C");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1 or 2.");
                    break;
            }
        }
    }

}
