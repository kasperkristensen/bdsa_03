using System;
using Xunit;
using Assignment03;

namespace Assignment03.Tests
{
    public class DelegateTests
    {
        [Fact]
        public void returns_product()
        {
            decimal x = 3;
            decimal y = 2;

            decimal expected = 6;
            Func<decimal, decimal, decimal> product = (x,y) => x * y;

            var actual = product(x,y);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void equality_between_0042_and_42()
        {
            var a = "0042";
            var b = 42;

            Func<string, int, bool> isTrue = (a,b) => Int32.Parse(a) == b;

            var actual = isTrue(a,b);

            Assert.True(actual);
        }

        [Fact]
        public void reverse_string()
        {
            Func<string, string> ReverseAction = x => {
                {
                    char[] cArray = x.ToCharArray();
                    string reverse = String.Empty;
                    for (int i = cArray.Length - 1; i > -1; i--)
                    {
                        reverse += cArray[i];
                    }
                    return reverse;
                }
            };

            var expected = "olleh";
            var actual = ReverseAction("hello");

            Assert.Equal(expected, actual);
        }
    }
}
