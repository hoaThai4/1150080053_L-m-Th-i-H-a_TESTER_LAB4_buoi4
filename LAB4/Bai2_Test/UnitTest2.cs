using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using LAB4;

namespace Bai2_Test
{
    [TestClass]
    public class UnitTest_Bai2
    {
        // 1. Kiểm tra tính toán đúng
        [TestMethod]
        public void TestCal_NormalCase()
        {
            // 1 + 2x + 3x^2, x = 2 => 17
            List<int> a = new List<int> { 1, 2, 3 };
            Polynomial p = new Polynomial(2, a);

            int actual = p.Cal(2);
            Assert.AreEqual(17, actual);
        }

        // 2. Thiếu hệ số
        [TestMethod]
        public void TestConstructor_NotEnoughCoefficients()
        {
            try
            {
                List<int> a = new List<int> { 1, 2 };
                Polynomial p = new Polynomial(2, a);
                Assert.Fail("Phải ném ra ArgumentException");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Invalid Data", ex.Message);
            }
        }

        // 3. n âm
        [TestMethod]
        public void TestConstructor_NegativeN()
        {
            try
            {
                List<int> a = new List<int> { 1 };
                Polynomial p = new Polynomial(-1, a);
                Assert.Fail("Phải ném ra ArgumentException");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Invalid Data", ex.Message);
            }
        }

        // 4. Đa thức bậc 0
        [TestMethod]
        public void TestCal_ZeroDegree()
        {
            List<int> a = new List<int> { 5 };
            Polynomial p = new Polynomial(0, a);

            int actual = p.Cal(100);
            Assert.AreEqual(5, actual);
        }
    }
}
