using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(-1, -10, 11, 0)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(100, 300, 500, 900)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 50, 50)]
        [InlineData(1000, 500, 500)]
        [InlineData(-268, 50, -318)]
        [InlineData(0, 0, 0)]


        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 10, 100)]
        [InlineData(100, 100, 10000)]
        [InlineData(-10, 6, -60)]
        [InlineData(-4, -100, 400)]
        [InlineData(0, 0, 0)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 10, 1)]
        [InlineData(100, 5, 20)]
        [InlineData(-90, -10, 9)]

        public void DivideTest(int num1, int num2, double expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
