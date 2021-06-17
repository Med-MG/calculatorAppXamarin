using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace calcAppSecTest
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