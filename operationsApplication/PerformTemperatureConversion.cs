using operationsLibrary;

namespace operationsApplication
{
    public class PerformTemperatureConversion
    {
        public string ConvertTemperature(int conversionType, double inputTemperature)
        {
            double result = 0;

            switch (conversionType)
            {
                case 1:
                    result = TemperatureConverter.CelsiusToFahrenheit(inputTemperature);
                    return $"{inputTemperature} °C is {result} °F";

                case 2:
                    result = TemperatureConverter.FahrenheitToCelsius(inputTemperature);
                    return $"{inputTemperature} °F is {result} °C";

                default:
                    return "Invalid option. Please choose 1 or 2.";
            }
        }
    }
}
