using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoadModel.Model;

namespace LoadModel.Test.Model
{
    /// <summary>
    /// Summary description for CohortTest
    /// </summary>
    [TestClass]
    public class CohortTest
    {
        public CohortTest()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestGetSizeAt_returns_zero_before_birth()
        {
            var sut = new Cohort { StartTime = 10, BaseSize = 10.0, GrowthRate = 2.0 };
            Assert.AreEqual(0.0, sut.GetTotalSizeAt(9));
        }

        [TestMethod]
        public void TestGetSizeAt_returns_correct_size()
        {
            var sut = new Cohort { Count = 2, StartTime = 10, BaseSize = 10.0, GrowthRate = 2.0 };
            Assert.AreEqual(28.0, sut.GetTotalSizeAt(12));
        }
    }
}
