using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16_toanTu3Ngoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tuoi;
            tuoi = Convert.ToInt32(Console.ReadLine());
            string kq = default;
            kq = (tuoi < 18) ? "Tre Con" : "Nguoi Lon";
            Console.WriteLine(kq);

            Console.Write("Nhap thoi Tiet Hom Nay : ");
            string thoitiet = Console.ReadLine();

            string result = (thoitiet == "mua") ? "Troi Mua" : "Troi Nang";
            Console.WriteLine(result);
        }
    }
}
