using System;
using Xunit;

namespace StringCalcTest2
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturn0WhenEmptyString()
        {
            var calc = new StringCalculator();
            var res = calc.Add("");
            Assert.Equal(0, res);
        }

        [Fact]
        public void SingleNumberIsReturned()
        { 
            var calc = new StringCalculator();
            var res = calc.Add("1");
            Assert.Equal(1, res);
        
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]

        public void AddWithComma(string num)
        {
            var calc = new StringCalculator();
            var res = calc.Add(num);
            Assert.Equal(Int32.Parse(num), res);
        }
    }
}