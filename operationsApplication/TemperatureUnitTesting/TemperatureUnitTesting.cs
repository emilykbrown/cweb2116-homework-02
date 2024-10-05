using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using operationsLibrary;

namespace operationsUnitTesting
{
    [TestClass]
    public class TemperatureUnitTesting
    {
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            // Arrange
            double input = 0;
            double expected = 32;

            // Act
            double result = TemperatureConverter.CelsiusToFahrenheit(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            // Arrange
            double input = 32;
            double expected = 0;

            // Act
            double result = TemperatureConverter.FahrenheitToCelsius(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
