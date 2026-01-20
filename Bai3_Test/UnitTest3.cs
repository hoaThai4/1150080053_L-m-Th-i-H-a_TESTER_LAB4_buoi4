using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LAB4;

namespace Bai3_Test
{
    [TestClass]
    public class UnitTest_Bai3
    {
        // 1. Đổi sang nhị phân (mặc định radix = 2)
        [TestMethod]
        public void TestConvert_ToBinary()
        {
            Radix r = new Radix(10);
            string actual = r.ConvertDecimalToAnother();
            Assert.AreEqual("1010", actual);
        }

        // 2. Đổi sang cơ số 8
        [TestMethod]
        public void TestConvert_ToOctal()
        {
            Radix r = new Radix(100);
            string actual = r.ConvertDecimalToAnother(8);
            Assert.AreEqual("144", actual);
        }

        // 3. Đổi sang hệ 16
        [TestMethod]
        public void TestConvert_ToHex()
        {
            Radix r = new Radix(255);
            string actual = r.ConvertDecimalToAnother(16);
            Assert.AreEqual("FF", actual);
        }

        // 4. Số nhỏ
        [TestMethod]
        public void TestConvert_SmallNumber()
        {
            Radix r = new Radix(5);
            string actual = r.ConvertDecimalToAnother(2);
            Assert.AreEqual("101", actual);
        }

        // 5. Số âm
        [TestMethod]
        public void TestConstructor_NegativeNumber()
        {
            try
            {
                Radix r = new Radix(-5);
                Assert.Fail("Phải ném ra ArgumentException");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Incorrect Value", ex.Message);
            }
        }

        // 6. Radix < 2
        [TestMethod]
        public void TestConvert_InvalidRadix_LessThan2()
        {
            try
            {
                Radix r = new Radix(10);
                r.ConvertDecimalToAnother(1);
                Assert.Fail("Phải ném ra ArgumentException");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Invalid Radix", ex.Message);
            }
        }

        // 7. Radix > 16
        [TestMethod]
        public void TestConvert_InvalidRadix_GreaterThan16()
        {
            try
            {
                Radix r = new Radix(10);
                r.ConvertDecimalToAnother(20);
                Assert.Fail("Phải ném ra ArgumentException");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Invalid Radix", ex.Message);
            }
        }
    }
}
