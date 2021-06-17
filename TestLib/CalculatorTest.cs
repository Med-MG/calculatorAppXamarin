using calcApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLib
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {

            // Arrange
            double expected = 5;

            // Act
            double actual = Calculator.Add(4, 1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sub_SimpleValuesShouldCalculate()
        {

            // Arrange
            double expected = 5;

            // Act
            double actual = Calculator.Subtract(10, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
