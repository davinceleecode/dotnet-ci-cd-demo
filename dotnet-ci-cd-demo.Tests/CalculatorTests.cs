using System;
using Xunit;
using dotnet_ci_cd_demo;

namespace dotnet_ci_cd_demo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            int result = calc.Add(50, 50);

            //Assert
            Assert.Equal(100, result);
        }


        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            int result = calc.Subtract(60, 30);

            //Assert
            Assert.Equal(30, result);
        }
    }
}
