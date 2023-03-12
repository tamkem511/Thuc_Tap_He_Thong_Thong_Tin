using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaiTapOOP.QuyUoc;

namespace BaiTapOOP
{
     class ThucHienGiaoDich
    {
        private long SoTienHienTai;
        private long SoTienNap;
        private long SoTienRut;
        private long STK;
        private long SoTienGD;

        public ThucHienGiaoDich()
        {
            SoTienHienTai = 0;
            SoTienNap = 0;
            SoTienRut = 0;
            STK = 0;
            SoTienGD = 0;
        }

        public long SoDu()
        {
            return SoTienHienTai;
        }

        public void NapTien()
        {
            Console.Write("Nhap So Tien Nap : ");
            SoTienNap = Convert.ToInt64(Console.ReadLine());
            if(SoTienNap < getMinGD())
            {
                Console.WriteLine("So Tien Khong Du De Nap Vao Tai Khoan !");
            }else if(SoTienNap > getMaxGD())
            {
                Console.WriteLine("So Tien Qua Lon Khong The Nap !");
            }
            else
            {
                SoTienHienTai += SoTienNap;
            }
        }

        public void RutTien()
        {
            Console.Write("Nhap So Tien Rut : ");
            SoTienRut = Convert.ToInt64(Console.ReadLine());
            if (SoTienRut < getMinGD())
            {
                Console.WriteLine("So Tien Khong Du De Rut Khoi Tai Khoan !");
            }
            else if (SoTienRut > getMaxGD())
            {
                Console.WriteLine("Tai Khoan Khong Du De Rut !");
            }
            else
            {
                SoTienHienTai -= SoTienRut;
            }
        }

        public void GiaoDich()
        {
            Console.Write("Nhap So Tai Khoan Muon Chuyen (Chi Co 4 So): ");
            STK = Convert.ToInt64(Console.ReadLine());
            Console.Write("Nhap So Tien Giao Dich : ");
            SoTienGD = Convert.ToInt64(Console.ReadLine());
            if (STK < 0 || STK > 9999)
            {
                Console.WriteLine("So Tai Khoan Khong Hop Le !");
            }else if(SoTienGD < getMinGD() || SoTienGD > getMaxGD())
            {
                Console.WriteLine("So Tien Giao Dich Khong Hop Le !");
            }
            else
            {
                SoTienHienTai = SoTienHienTai - SoTienGD - getCuocPhi();
                Console.WriteLine("Giao Dich Thanh Cong");
            }
        }
    }
}
