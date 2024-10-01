using System;
using NUnit.Framework;
using operationsLibrary;

public class TemperatureUnitTesting
{
    private const string Message = "Fahrenheit to Celsius conversion failed for negative values.";

    [Test]
    public void TestCelsiusToFahrenheit()
    {
        // Arrange
        double celsius = 0;
        double expectedFahrenheit = 32;

        // Act
        double result = TemperatureConverter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.AreEqual(expectedFahrenheit, result, 0.001, "Celsius to Fahrenheit conversion failed.");
    }

    [Test]
    public void TestFahrenheitToCelsius()
    {
        // Arrange
        double fahrenheit = 32;
        double expectedCelsius = 0;

        // Act
        double result = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.AreEqual(expectedCelsius, result, 0.001, "Fahrenheit to Celsius conversion failed.");
    }

    [Test]
    public void TestCelsiusToFahrenheitWithNegativeValue()
    {
        // Arrange
        double celsius = -40;
        double expectedFahrenheit = -40;

        // Act
        double result = TemperatureConverter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.AreEqual(expectedFahrenheit, result, 0.001, "Celsius to Fahrenheit conversion failed for negative values.");
    }

    [Test]
    public void TestFahrenheitToCelsiusWithNegativeValue()
    {
        // Arrange
        double fahrenheit = -40;
        double expectedCelsius = -40;

        // Act
        double result = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.AreEqual(expectedCelsius, result, 0.001, Message);
    }

    [Test]
    public void TestCelsiusToFahrenheitWithDecimalValue()
    {
        // Arrange
        double celsius = 37.5;
        double expectedFahrenheit = 99.5;

        // Act
        double result = TemperatureConverter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.AreEqual(expectedFahrenheit, result, 0.001, "Celsius to Fahrenheit conversion failed for decimal values.");
    }

    [Test]
    public void TestFahrenheitToCelsiusWithDecimalValue()
    {
        // Arrange
        double fahrenheit = 99.5;
        double expectedCelsius = 37.5;

        // Act
        double result = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.AreEqual(expectedCelsius, result, 0.001, "Fahrenheit to Celsius conversion failed for decimal values.");
    }
}
