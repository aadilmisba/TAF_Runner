using NUnit.Framework;

namespace HT_Nunit_TR
{
    [TestFixture]
    public class Tests
    {
        [OneTimeSetUp]
        public static void ClassPrecondition()
        {
            TestContext.WriteLine("Nunit Class output");
        }

        [SetUp]
        public void TestPrecondition()
        {
            TestContext.WriteLine("Nunit Test output");
        }


        [Test]
        public void TestPassScenario()
        {
            string expected = "Aadil";
            string actual = "Aadil";
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestPassScenario2()
        {
            void FunctionUnderTest()
            {
                throw new Exception();
            }

            Action _functionUnderTest = FunctionUnderTest;
            Assert.Throws<Exception>(() =>_functionUnderTest());

        }

        [TestCase(4, 8, 12)]
        [TestCase(5, 10, 15)]
        [TestCase(100, 200, 300)]
        public void Test_Add(double x, double y, double e)
        {
            double expected = e;
            double actual = x + y;
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        [Ignore("Checking the ignore attribute")]
        public void TestIgnore()
        {
            TestContext.WriteLine("Ignoring test");
        }

        [Test]
        public void Assertion_Fail()
        {
            Assert.Fail();
        }

        [Test]
        public void TestResultFail()
        {
            string expected = "Aadil";
            string actual = "Aadil3";
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void NUnitTearDown()
        {
            TestContext.WriteLine("Nunit Test output");
        }

        [OneTimeTearDown]
        public void NUnitOneTimeTearDown()
        {
            TestContext.WriteLine("Nunit Class output");
        }

    }
}