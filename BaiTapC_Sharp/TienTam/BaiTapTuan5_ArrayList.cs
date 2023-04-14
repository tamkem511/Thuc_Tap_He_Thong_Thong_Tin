using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapC_Sharp.TamKem
{
    internal class BaiTapTuan5_ArrayList
    {
        static void Main()
        {
            ArrayList x = new ArrayList();

            x.Add(1);
            x.Add(2);
            x.Add(3);
            x.Add(4);
            x.Add(5);
            x.Add(6);
            x.Add(7);
            x.Add(8);
            x.Add(9);

            foreach (var item in x)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("===== Sau Khi Xoa =====");

            x.RemoveAt(0);

            x.RemoveRange(2, 2);

            foreach (var item in x)
            {
                Console.Write(item + " ");
            }


        }
    }
}


