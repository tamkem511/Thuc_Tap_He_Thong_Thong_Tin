using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan6_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School sc = new School("Dai Hoc Cong Nghiep");
            sc.Nhap();
            sc.InTT();

        }
    }
}
