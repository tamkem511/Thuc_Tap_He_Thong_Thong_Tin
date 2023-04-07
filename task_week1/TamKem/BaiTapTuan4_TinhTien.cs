using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task_week1.TamKem
{
    internal class Program
    {
        static void Nhap(ref float soDau, ref float soCuoi)
        {
            try
            {
                Console.Write("Nhap So Dau : ");
                soDau = System.Convert.ToSingle(Console.ReadLine());
                Console.Write("Nhap So Cuoi : ");
                soCuoi = System.Convert.ToSingle(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Gia tri nhap khong dung dinh dang");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR : " + e.ToString());
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static float TinhTien(ref float soDau, ref float soCuoi)
        {
            float TongTien = 0;
            float SoDien = soCuoi - soDau;
            if (SoDien < 100)
            {
                TongTien += 2000;
            }
            else if (SoDien < 150)
            {
                TongTien += 100 * 2000 + (SoDien - 100) * 2500;
            }
            else if (SoDien < 200)
            {
                TongTien += 100 * 2000 + 50 * 2500 + (SoDien - 150) * 2800;
            }
            else
            {
                TongTien += 100 * 2000 + 50 * 2500 + 50 * 2800 + (SoDien - 200) * 3500;
            }
            return TongTien;
        }
        static void Main(string[] args)
        {
            float soDau = 0, soCuoi = 0;
            float KM = 0;
            Nhap(ref soDau, ref soCuoi);
            Console.WriteLine(TinhTien(ref soDau, ref soCuoi));
        }
    }
}

