using System;
using Xunit;

namespace StringCalculatorKata
{
    public class CalculatorShould
    {
        [Fact]
        public void ReturnZeroWhenEmptyInput()
        {
            var result = StringCalculator.Add("");
            Assert.Equal(0, result);
        }
        
        [Theory]
        [InlineData("4", 4)]
        [InlineData("4,4", 8)]
        [InlineData("4,4,3,3", 14)]
        public void SumExpressionWithAddends(string expression,int expected)
        {
            var result = StringCalculator.Add(expression);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("4\n4", 8)]
        [InlineData("4\n4,4", 12)]
        public void AcceptNewLineExpressionSeparators(string expression,int expected)
        {
            var result = StringCalculator.Add(expression);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void AcceptCustomSeparator()
        {
            var result = StringCalculator.Add("//;\n4;4");
            Assert.Equal(8, result);
        }
        
        [Fact]
        public void AcceptCustomSeparatorMoreThanOneCharacter()
        {
            var result = StringCalculator.Add("//;w\n4;w4");
            Assert.Equal(8, result);
        }
    }
}