using NUnit.Framework;
using System;

namespace NUnitTest
{
    public class Test1 : BaseTest
    {
        [Test, Category(TestCategory.Smoke)]
        public void Test01()
        {
            Random random = new Random();
            int number = random.Next(1, 5);
            Assert.That(number.Equals(2));
        }

        [Test, Category(TestCategory.Smoke)]
        public void Test02()
        {
            Random random = new Random();
            int number = random.Next(1, 5);
            Console.WriteLine(number);
        }
    }
}