using dotnet_lib;
using Xunit;

namespace dotnet_core_tests_xunittests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            new Model().Do();
        }
    }
}
