using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai44_SuDungProperties_Get_Set
{
    class Student
    {
        private string MaSV;
        private string HoTen;
        private int Tuoi;

        public Student(string MaSV, string HoTen, int Tuoi)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.Tuoi = Tuoi;
        }

        public string MSV
        {
            get { return MaSV; }
            set
            {
                if (value.Length > 0 && value.Length <= 10)
                {
                    MaSV = value;
                }
                else
                {
                    Console.WriteLine("Du Lieu Khong Hop Le");
                }
            }
        }

        public string Name
        {
            get { return HoTen; }

            set
            {
                if (value.Length > 0 && value.Length < 30)
                {
                    HoTen = value;
                }
                {
                    Console.WriteLine("Du Lieu Khong Hop Le");
                }
            }
        }
    }
}
