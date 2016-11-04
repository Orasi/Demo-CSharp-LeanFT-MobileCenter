using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.Verifications;

namespace Demo_CSharp_LeanFT_MobileCenter
{
    [TestFixture]
    public class LeanFtTest1 : UnitTestClassBase<LeanFtTest>
    {
        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
        }

        [Test]
        public void TestNunit()
        {
            Assert.AreEqual(1, 1);
            
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
