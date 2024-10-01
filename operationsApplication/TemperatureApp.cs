using System;

namespace TemperatureConverterLibrary
{
    public class TemperatureApp
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
        // Method to perform conversion without user interaction
        public string ConvertTemperature(int conversionType, double inputTemperature)
        {
            double result = 0;

            switch (conversionType)
            {
                case 1:
                    result = TemperatureApp.CelsiusToFahrenheit(inputTemperature);
                    return $"{inputTemperature} °C is {result} °F";

                case 2:
                    result = TemperatureApp.FahrenheitToCelsius(inputTemperature);
                    return $"{inputTemperature} °F is {result} °C";
            
                default:
                    return false;
             }
        }
    }
}