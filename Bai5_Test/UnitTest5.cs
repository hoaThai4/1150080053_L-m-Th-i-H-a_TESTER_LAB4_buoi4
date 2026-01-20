using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB4;
using System.Collections.Generic;

namespace Bai5_Test
{
    [TestClass]
    public class UnitTest_Bai5
    {
        // 1. Test tính điểm trung bình
        [TestMethod]
        public void TestDiemTrungBinh()
        {
            HocVien hv = new HocVien("HV01", "Nguyen Van A", "Ha Noi", 9, 8, 7);
            double dtb = hv.DiemTrungBinh();
            Assert.AreEqual(8.0, dtb);
        }

        // 2. Học viên đủ điều kiện học bổng
        [TestMethod]
        public void TestHocVien_DuDieuKienHocBong()
        {
            HocVien hv = new HocVien("HV02", "Tran Thi B", "Hue", 8, 9, 8);
            Assert.IsTrue(hv.DuocHocBong());
        }

        // 3. Trung bình >= 8 nhưng có môn dưới 5 → không đạt
        [TestMethod]
        public void TestHocVien_TruotViMonDuoi5()
        {
            HocVien hv = new HocVien("HV03", "Le Van C", "Da Nang", 9, 9, 4);
            Assert.IsFalse(hv.DuocHocBong());
        }

        // 4. Trung bình < 8 → không đạt
        [TestMethod]
        public void TestHocVien_TrungBinhDuoi8()
        {
            HocVien hv = new HocVien("HV04", "Pham Thi D", "Sai Gon", 7, 7, 7);
            Assert.IsFalse(hv.DuocHocBong());
        }

        // 5. Test danh sách học bổng trong quản lý
        [TestMethod]
        public void TestDanhSachHocBong()
        {
            QuanLyHocVien ql = new QuanLyHocVien();

            HocVien hv1 = new HocVien("HV01", "A", "HN", 8, 8, 8); // đạt
            HocVien hv2 = new HocVien("HV02", "B", "HP", 9, 9, 4); // trượt
            HocVien hv3 = new HocVien("HV03", "C", "DN", 9, 8, 9); // đạt

            ql.ThemHocVien(hv1);
            ql.ThemHocVien(hv2);
            ql.ThemHocVien(hv3);

            List<HocVien> dsHocBong = ql.LayDanhSachHocBong();

            Assert.AreEqual(2, dsHocBong.Count);
            Assert.IsTrue(dsHocBong.Contains(hv1));
            Assert.IsTrue(dsHocBong.Contains(hv3));
        }
    }
}
