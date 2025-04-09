using System;
using Xunit;
using Xunit.Abstractions;

namespace XunitTest
{
    public class BaseTest : IDisposable
    {
        protected readonly ITestOutputHelper Output;

        public BaseTest(ITestOutputHelper output)
        {
            Output = output;
            Output.WriteLine("start of test");
        }

        public void Dispose()
        {
            Output.WriteLine("end of test");
        }
    }
}
