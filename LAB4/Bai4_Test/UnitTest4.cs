using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB4;
using System;

namespace Bai4_Test
{
    [TestClass]
    public class UnitTest_Bai4
    {
        // 1. Test tính diện tích
        [TestMethod]
        public void TestTinhDienTich()
        {
            Diem trenTrai = new Diem(1, 5);
            Diem duoiPhai = new Diem(6, 1);
            HinhChuNhat hcn = new HinhChuNhat(trenTrai, duoiPhai);

            double dienTich = hcn.TinhDienTich();
            Assert.AreEqual(20, dienTich);
        }

        // 2. Hai hình giao nhau
        [TestMethod]
        public void TestCoGiaoNhau_True()
        {
            HinhChuNhat h1 = new HinhChuNhat(
                new Diem(0, 5),
                new Diem(5, 0)
            );

            HinhChuNhat h2 = new HinhChuNhat(
                new Diem(3, 4),
                new Diem(7, 1)
            );

            bool result = h1.CoGiaoNhau(h2);
            Assert.IsTrue(result);
        }

        // 3. Hai hình không giao nhau
        [TestMethod]
        public void TestCoGiaoNhau_False()
        {
            HinhChuNhat h1 = new HinhChuNhat(
                new Diem(0, 5),
                new Diem(5, 0)
            );

            HinhChuNhat h2 = new HinhChuNhat(
                new Diem(6, 4),
                new Diem(9, 1)
            );

            bool result = h1.CoGiaoNhau(h2);
            Assert.IsFalse(result);
        }

        // 4. Kiểm tra dữ liệu sai
        [TestMethod]
        public void TestConstructor_InvalidRectangle()
        {
            try
            {
                Diem trenTrai = new Diem(5, 1);
                Diem duoiPhai = new Diem(2, 4); // Sai vị trí
                HinhChuNhat hcn = new HinhChuNhat(trenTrai, duoiPhai);
                Assert.Fail("Phải ném ra ArgumentException");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Invalid Rectangle", ex.Message);
            }
        }
    }
}
