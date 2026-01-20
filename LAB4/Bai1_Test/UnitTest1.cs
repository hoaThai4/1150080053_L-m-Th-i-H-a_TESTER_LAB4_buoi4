using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB4;

namespace Bai1_Test
{
    [TestClass]
    public class UnitTest_Bai1
    {
        // n = 0
        [TestMethod]
        public void TestPower_N0()
        {
            double result = Bai1.Power(5, 0);
            Assert.AreEqual(1.0, result);
        }

        // n > 0
        [TestMethod]
        public void TestPower_PositiveN()
        {
            double result = Bai1.Power(2, 3); // 2^3 = 8
            Assert.AreEqual(8.0, result);
        }

        // n < 0
        [TestMethod]
        public void TestPower_NegativeN()
        {
            double result = Bai1.Power(2, -2); // 2^-2 = 1/4
            Assert.AreEqual(0.25, result);
        }

        // x = 0, n > 0
        [TestMethod]
        public void TestPower_XZero()
        {
            double result = Bai1.Power(0, 3);
            Assert.AreEqual(0.0, result);
        }

        // x = 1, mọi n
        [TestMethod]
        public void TestPower_XOne()
        {
            double result = Bai1.Power(1, -100);
            Assert.AreEqual(1.0, result);
        }
    }
}
