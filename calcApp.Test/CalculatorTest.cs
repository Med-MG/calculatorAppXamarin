using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace calcApp.Test
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

    }
}
