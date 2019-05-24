using dotnet_lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_core_tests_mstests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            new Model().Do();
        }
    }
}
