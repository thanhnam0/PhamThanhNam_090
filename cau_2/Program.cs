using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_2
{
    class HinhChuNhat
    {
        private double dai;
        private double rong;
        
        public HinhChuNhat()
        {

        }
        public HinhChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
            

        }
        public double Dai
        {
            get { return dai; }
            set { this.dai = value; }
        }
        public double Rong
        {
            get { return rong; }
            set { this.rong = value; }
        }
       
        public double chuVi()
        {
            return (dai + rong) * 2;
        }
        public double tinhDienTich()
        {
            return (dai * rong);
        }
        class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
