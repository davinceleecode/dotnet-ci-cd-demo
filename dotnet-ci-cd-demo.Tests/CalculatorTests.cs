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
            int result = calc.Add(1, 1);

            //Assert
            Assert.Equal(2, result);
        }


        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            int result = calc.Subtract(100, 100);

            //Assert
            Assert.Equal(0, result);
        }
    }
}
