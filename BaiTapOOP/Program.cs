using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP
{
    internal class Start
    {
        static void Main(string[] args)
        {
            ThucHienGiaoDich x = new ThucHienGiaoDich();
            Console.WriteLine("========= Quy Uoc Giao Dich =========");
            QuyUoc.QuyUocGD();
            Console.WriteLine("======== Chuong Trinh ========");
            Console.WriteLine("1.Xem So Du Tai Khoan");
            Console.WriteLine("2.Nap Tien");
            Console.WriteLine("3.Rut Tien");
            Console.WriteLine("4.Giao Dich");
            int lc;

            while (true)
            {
                Console.Write("Nhap Lua Chon : ");
                lc = System.Int32.Parse(Console.ReadLine());
                switch (lc)
                {
                    case 1:
                        {
                            Console.WriteLine("So Du : " + x.SoDu());

                        }; break;

                    case 2:
                        {
                            x.NapTien();
                        }; break;

                    case 3:
                        {
                            x.RutTien();
                        }; break;
                    case 4:
                        {
                            x.GiaoDich();
                        }; break;
                }
            }
        }
    }


}
