using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{  // Lớp điểm trong mặt phẳng 2D
    public class Diem
    {
        public double X { get; set; }  // Hoành độ
        public double Y { get; set; }  // Tung độ

        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    // Lớp hình chữ nhật
    public class HinhChuNhat
    {
        private Diem trenTrai;     // Điểm trên bên trái
        private Diem duoiPhai;     // Điểm dưới bên phải

        public HinhChuNhat(Diem trenTrai, Diem duoiPhai)
        {
            // Kiểm tra dữ liệu hợp lệ
            if (trenTrai.X >= duoiPhai.X || trenTrai.Y <= duoiPhai.Y)
                throw new ArgumentException("Invalid Rectangle");

            this.trenTrai = trenTrai;
            this.duoiPhai = duoiPhai;
        }
        // Tính diện tích
        public double TinhDienTich()
        {
            double chieuRong = duoiPhai.X - trenTrai.X;
            double chieuCao = trenTrai.Y - duoiPhai.Y;
            return chieuRong * chieuCao;
        }
        // Kiểm tra giao nhau
        public bool CoGiaoNhau(HinhChuNhat hcn)
        {
            // Nếu một hình nằm hoàn toàn bên trái, phải, trên hoặc dưới hình kia
            if (this.duoiPhai.X <= hcn.trenTrai.X ||
                this.trenTrai.X >= hcn.duoiPhai.X ||
                this.trenTrai.Y <= hcn.duoiPhai.Y ||
                this.duoiPhai.Y >= hcn.trenTrai.Y)
            {
                return false;
            }
            return true;
        }
    }
}