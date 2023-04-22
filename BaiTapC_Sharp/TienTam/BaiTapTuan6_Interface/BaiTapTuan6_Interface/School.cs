using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan6_Interface
{
    interface HieuTruong
    {
        void SetHieuTruong(string HT, string SDT);
        string GetHieuTruong();
    }

    interface DiaChi
    {
        void SetDiaChi(string TP);

        string GetDiaChi();
    }
    class School : HieuTruong, DiaChi
    {
        public string TenTruong;
        public string HoTen;
        public string SoDT;
        public string DC;

        public School(string TT)
        {
            TenTruong = TT;
        }

        public void SetHieuTruong(string HT, string SDT)
        {
            this.HoTen = HT;
            this.SoDT = SDT;
        }
        public void SetDiaChi(string TP)
        {
            this.DC = TP;
        }

        public string GetHieuTruong()
        {
            return HoTen;
        }

        public string GetDiaChi()
        {
            return DC;
        }

        public void Nhap()
        {
            HoTen = Console.ReadLine();
            SoDT = Console.ReadLine();
            DC = Console.ReadLine();
        }
        public void InTT()
        {
            Console.WriteLine("Ten Truong : " + TenTruong);
            SetHieuTruong(HoTen, SoDT);
            SetDiaChi(DC);
            Console.WriteLine(GetHieuTruong());
            Console.WriteLine(GetDiaChi());
        }
    }
}
