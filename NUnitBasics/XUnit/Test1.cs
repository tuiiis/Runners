using NUnitTest;
using System;
using Xunit;
using Xunit.Abstractions;

namespace XunitTest
{
    public class Test1 : BaseTest
    {
        public Test1(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait("Category", TestCategory.Smoke)]
        public void Test01()
        {
            Random random = new Random();
            int number = random.Next(1, 5);
            Assert.Equal(2, number);
        }

        [Fact]
        [Trait("Category", TestCategory.Smoke)]
        public void Test02()
        {
            Random random = new Random();
            int number = random.Next(1, 5);
            Output.WriteLine($"Generated number: {number}");
        }
    }
}
