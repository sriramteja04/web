using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expected = 9;
            var x = 3;
            var y = 2;
            var actual = power(3,2);
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(4, 2, 16)]
        public void Test2(int a, int b, int expected)
        {
            Assert.Equal(expected, power(a,b));
        }


        int power(int x, int power) {
            var output = 1;
            for(int i=power ;i >= 1; i--)
            {
                output = output * x;
            }
            return output;
        }                                      
    }
}
