using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Abstractions;

namespace HT_Xunit_TR
{
    public class UnitTest1 : IClassFixture<XunitSetupClass>, IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        

        public UnitTest1(ITestOutputHelper testOutputHelper, XunitSetupClass XunitSetupClass)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Xunit test Test Precondition output");
        }
        
        [Fact]
        public void TestPassScenario()
        {
            string expected = "Aadil";
            string actual = "Aadil";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPassScenario2()
        {
            void FunctionUnderTest()
            {
                throw new Exception();
            }

            Action _functionUnderTest = FunctionUnderTest;
            Assert.Throws<Exception>(() => _functionUnderTest());

        }

        [Theory]
        [InlineData("First Test")]
        [InlineData("Second Test")]
        public void Test_Theory(string parameter)
        {
            _testOutputHelper.WriteLine(parameter);
        }

        [Fact(Skip = "Checking the skip attribute")]
        public void Test_Ignore()
        {
            _testOutputHelper.WriteLine("Xunit test Method output");
        }

        [Fact]
        public void Test_Fail()
        {
            Assert.Empty("Failing the test");
            // Assert.Fail() method is not available
        }

        [Fact]
        public void TestResultFail()
        {
            string expected = "Aadil";
            string actual = "Aadil3";
            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
            _testOutputHelper.WriteLine("Xunit test Test Postcondition output");
        }

    }

    public class XunitSetupClass : IDisposable
    {
        public XunitSetupClass()
        {
            int i = 0;
        }

        public void Dispose()
        {
            int k = 1;
        }

    }
}