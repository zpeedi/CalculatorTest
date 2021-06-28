using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class ProgramTests
    {
        
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-2, 3, 1)]
        [InlineData(2, -3, -1)]
        public void TestAddTuple(double n1, double n2, double expected)
        {
            Program.Numbers numbers = new Program.Numbers();
            numbers.number1 = n1;
            numbers.number2 = n2;
            double result = Program.Add(numbers);

            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void TestAddArray()
        {
            double[] numbers = new double[] { 1, 2, 3};
            double expected = 6.0;
            double result = Program.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(-2, 3, -5)]
        [InlineData(2, -3, 5)]
        public void TestSubtractTuple(double n1, double n2, double expected)
        {
            Program.Numbers numbers = new Program.Numbers();
            numbers.number1 = n1;
            numbers.number2 = n2;
            double result = Program.Subtract(numbers);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSubtractArray()
        {
            double[] numbers = new double[] { 1, 2, 3 };
            double expected = -4;
            double result = Program.Subtract(numbers);

            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(2, 4, 0.5)]
        [InlineData(-2, 4, -0.5)]
        [InlineData(1, 3, 0.333)]
        [InlineData(1, 0, double.PositiveInfinity)]
        public void TestDivideTuple(double n1, double n2, double expected)
        {
            Program.Numbers numbers = new Program.Numbers();
            numbers.number1 = n1;
            numbers.number2 = n2;
           
            double result = Program.Divide(numbers);

            Assert.Equal(expected, result, 3);
        }

        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(-2, 4, -8)]
        [InlineData(1, 3, 3)]
        [InlineData(1, 0, 0)]
        public void TestMultiplyTuple(double n1, double n2, double expected)
        {
            Program.Numbers numbers = new Program.Numbers();
            numbers.number1 = n1;
            numbers.number2 = n2;

            double result = Program.Multiply(numbers);

            Assert.Equal(expected, result);
        }
    }


}
