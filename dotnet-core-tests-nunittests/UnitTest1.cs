using dotnet_lib;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            new Model().Do();
            Assert.Pass();
        }
    }
}