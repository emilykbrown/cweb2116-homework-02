namespace operationsLibrary
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
    
}