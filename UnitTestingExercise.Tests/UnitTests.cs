using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(5, -10, -5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2, 0, 0)]
        [InlineData(2, 2, 4)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 1)]
        [InlineData(12, 3, 4)]
        [InlineData(12, 0, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MyStringMethod()
        {
            //Arrange
            //var expected = 'hey';
            var test = new UnitTestMethods();

            //Act
            bool actual = test.MyStringMethod();

            //Assert
            Assert.True(actual, "Hey");
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            bool actual = test.MySecondMethod();

            //Assert
            Assert.False(actual, "Yep that's false");
        }
    }
}
