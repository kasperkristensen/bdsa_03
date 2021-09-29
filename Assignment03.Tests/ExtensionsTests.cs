using System;
using Xunit;
using Assignment03;

namespace Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void is_secure_return_true_on_https()
        {
            var str =  new Uri("https://www.microsoft.com");
            var actual = str.IsSecure();

            Assert.True(actual);
        }

        [Fact]
        public void is_secure_return_false_on_http()
        {
            var str =  new Uri("http://www.microsoft.com");
            var actual = str.IsSecure();

            Assert.False(actual);
        }

        [Fact]
        public void word_count_should_return_2()
        {
            var str = "hey there m8";
            var actual = str.WordCount();

            Assert.Equal(2, actual);
        }
    }
}
