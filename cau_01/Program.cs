using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_01
{
    class NhanVien
    {
        private string hoTen;
        private int soNgayCong;
        private int soNgayLamThem;
        private string xepLoai;
        private string boPhan;
        public NhanVien()
        {

        }
        public NhanVien(string hoTen,int soNgayCong,int soNgayLamThem,string xepLoai,string boPhan)
        {
            this.hoTen = hoTen;
            this.soNgayCong = soNgayCong;
            this.soNgayLamThem = soNgayLamThem;
            this.xepLoai = xepLoai;
            this.boPhan = boPhan;
        }
        private string HoTen
        {
            set { this.hoTen = value; }
            get { return HoTen; }
        }
        private int SoNgayCong
        {
            set { this.soNgayCong = value; }
            get { return SoNgayCong; }
        }
        private int SoNgayLamThem
        {
            set { this.soNgayLamThem = value; }
            get { return SoNgayLamThem; }
        }
        private string XepLoai
        {
            set { this.xepLoai = value; }
            get { return XepLoai; }
        }
        private string BoPhan
        {
            set { this.boPhan = value; }
            get { return BoPhan; }
        }
        public double congthucluong(double Luong)
        {
            double TangLuong;
            double LuongMotNgay = 100000;
            if (boPhan is "tructiep")
            {
                TangLuong = 300;
            }
            else
            {
                TangLuong = 200;
            }
            return Luong = (soNgayCong + soNgayLamThem * TangLuong) * LuongMotNgay;
        }
        public void cachxeploai()
        {
            double thunhap = 0;
            double luong;
            luong = congthucluong();   
            if (XepLoai is "A")
            {
                thunhap = luong * 1.5;
            }
            else if (XepLoai is "B")
            {
                thunhap = luong * 1.2;
            }
            else
            {
                thunhap = luong;
            }
            Console.WriteLine("ho va ten : {0}", hoTen);
            Console.WriteLine("bo phan : {0}", boPhan);
            Console.WriteLine("thu nhap : {0}", thunhap);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1 = new NhanVien();
            Console.WriteLine("moi nhap ho ten: ");
            
        }
    }
}
