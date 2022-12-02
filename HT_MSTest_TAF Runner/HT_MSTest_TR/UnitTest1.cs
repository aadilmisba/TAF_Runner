namespace HT_MSTest_TR
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassPrecondition(TestContext testContext)
        {
            testContext.WriteLine("MS test Class output");
        }

        [TestInitialize]
        public void TestPrecondition()
        {
            TestContext.WriteLine("MS test Test output");
        }

        [TestMethod]
        public void TestPassScenario()
        {
            string expected = "Aadil";
            string actual = "Aadil";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPassScenario2()
        {

            void FunctionUnderTest()
            {
                throw new Exception();
            }

            Action _functionUnderTest = FunctionUnderTest;
            Assert.ThrowsException<Exception>(() => _functionUnderTest());

        }

        [DataTestMethod]
        [DataRow(8, 4, 4)]
        [DataRow(10, 5, 5)]
        [DataRow(10, 10, 0)]
        public void Test_Sub(double x, double y, double e)
        {
            double expected = e;
            double actual = x - y;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [Ignore("Checking the ignore attribute")]
        public void Test_Ignore()
        {
            TestContext.WriteLine("Ignoring Test");
        }

        [TestMethod]
        public void Test_Fail()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void Test_Fail2()
        {
            string expected = "Aadil";
            string actual = "Aadil3";
            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            TestContext.WriteLine("MS test Test output");
        }

        [ClassCleanup]
        public static void MSTestClassCleanup()
        {
            int i = 0;
        }

    }
}