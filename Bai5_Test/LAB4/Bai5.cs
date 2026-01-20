using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{    // Lớp học viên
    public class HocVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public double Diem1 { get; set; }
        public double Diem2 { get; set; }
        public double Diem3 { get; set; }

        public HocVien(string maSo, string hoTen, string queQuan,
                       double diem1, double diem2, double diem3)
        {
            MaSo = maSo;
            HoTen = hoTen;
            QueQuan = queQuan;
            Diem1 = diem1;
            Diem2 = diem2;
            Diem3 = diem3;
        }

        // Tính điểm trung bình
        public double DiemTrungBinh()
        {
            return (Diem1 + Diem2 + Diem3) / 3.0;
        }

        // Kiểm tra có đạt học bổng không
        public bool DuocHocBong()
        {
            return DiemTrungBinh() >= 8.0 &&
                   Diem1 >= 5 && Diem2 >= 5 && Diem3 >= 5;
        }
    }

    // Lớp quản lý học viên
    public class QuanLyHocVien
    {
        private List<HocVien> danhSach = new List<HocVien>();

        public void ThemHocVien(HocVien hv)
        {
            danhSach.Add(hv);
        }

        public List<HocVien> LayDanhSachHocBong()
        {
            return danhSach.Where(hv => hv.DuocHocBong()).ToList();
        }

        public List<HocVien> LayTatCaHocVien()
        {
            return danhSach;
        }
    }
}