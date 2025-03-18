﻿using System;
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
            int result = calc.Add(3, 5);

            //Assert
            Assert.Equal(8, result);
        }


        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            int result = calc.Subtract(6, 5);

            //Assert
            Assert.Equal(1, result);
        }
    }
}
