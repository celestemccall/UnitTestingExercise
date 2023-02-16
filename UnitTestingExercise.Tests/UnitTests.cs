using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 2, 2, 8)]
        [InlineData(1,2,2, 5)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = calculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,4,1)]//Add test data <-------
        [InlineData(8,2,6)]
        [InlineData(10,5,5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var subcalculator = new Calculator();

            //Act

            var actual = subcalculator.Subtract(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1,5,5)]//Add test data <-------
        [InlineData(2,2,4)]
        [InlineData(3,5,15)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var mulcalculator = new Calculator();

            //Act

            var actual = mulcalculator.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,2,5)]//Add test data <-------
        [InlineData(15,5,3)]
        [InlineData(50,5,10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var divcalculator = new Calculator();

            //Act

            var actual = divcalculator.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
