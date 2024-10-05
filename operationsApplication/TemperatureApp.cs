using System;

namespace operationsApplication
{
    class TemperatureApp
    {
        static void Main(string[] args)
        {
            PerformTemperatureConversion converter = new PerformTemperatureConversion();

            Console.WriteLine("Temperature Conversion App");
            Console.WriteLine("Choose the type of conversion:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            string choice = Console.ReadLine();
            int conversionType = int.Parse(choice);

            Console.WriteLine("Enter temperature:");
            double inputTemperature = Convert.ToDouble(Console.ReadLine());

            string result = converter.ConvertTemperature(conversionType, inputTemperature);
            Console.WriteLine(result);
        }
    }
}
