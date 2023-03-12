using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP
{
     static class QuyUoc
    {
        private static long minGD;
        private static long maxGD;
        private static int CuocPhi;

        static QuyUoc()
        {
            minGD = 10000;
            maxGD = 1000000;
            CuocPhi = 5000;
        }

        public static void QuyUocGD()
        {
            Console.WriteLine("Muc Thap Nhat Co The Giao Dich : " + minGD);
            Console.WriteLine("Muc Cao Nhat Co The Giao Dich : " + maxGD);
            Console.WriteLine("Cuoc Phi 1 Lan Giao Dich : " + CuocPhi);
        }

        public static long getMinGD()
        {
            return minGD;
        }

        public static long getMaxGD()
        {
            return maxGD;
        }

        public static int getCuocPhi()
        {
            return CuocPhi;
        }
    }
}
