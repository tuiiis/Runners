using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace NUnitTest
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("start of all tests");
        }

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine($"start of test {TestContext.CurrentContext.Test.Name}");
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Console.WriteLine("test failed");
            }
            Console.WriteLine($"end of test {TestContext.CurrentContext.Test.Name}");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("end of all tests");
        }
    }
}