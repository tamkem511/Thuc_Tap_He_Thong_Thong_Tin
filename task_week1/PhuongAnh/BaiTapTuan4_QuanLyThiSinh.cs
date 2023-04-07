using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public class ThiSinh
    {
        private string sbd;
        private string hoTen;
        private float diemVan;
        private float diemAnh;

        public string Sbd { get => sbd; set => sbd = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public float DiemVan { get => diemVan; set => diemVan = value; }
        public float DiemAnh { get => diemAnh; set => diemAnh = value; }

        public ThiSinh()
        {
            Sbd = HoTen = "";
            DiemVan = DiemAnh = 0;
        }
        public ThiSinh(string sbd, string hoten, float diemvan, float diemanh)
        {
            this.Sbd = sbd;
            this.HoTen = hoTen;
            this.DiemVan = diemvan;
            this.DiemAnh = diemanh;
        }

        public virtual float TongDiem()
        {
            return DiemAnh + DiemVan;
        }
    }

    class ThiSinhUT : ThiSinh
    {
        private int khuVuc;
        private float diemUT;

        public int KhuVuc { get => khuVuc; set => khuVuc = value; }
        public float DiemUT { get => diemUT; set => diemUT = value; }

        public ThiSinhUT() : base()
        {
            KhuVuc = 0;
            DiemUT = 0f;
        }

        public ThiSinhUT(string sbd, string hoten, float diemvan, float diemanh, int kv, float diemut) : base(sbd, hoten, diemvan, diemanh)
        {
            KhuVuc = kv;
            DiemUT = diemut;
        }

        public void Nhap()
        {
            Console.Write("Nhap So Bao Danh : ");
            Sbd = Console.ReadLine();
            Console.Write("Nhap Ho Ten : ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Diem Van : ");
            DiemVan = System.Single.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Anh : ");
            DiemAnh = System.Single.Parse(Console.ReadLine());
            Console.Write("Nhap Khu Vuc : ");
            KhuVuc = System.Int32.Parse(Console.ReadLine());
            if (KhuVuc == 1)
            {
                DiemUT = 0;
            }
            else if (KhuVuc == 2)
            {
                DiemUT = 0.25f;
            }
            else
            {
                DiemUT = 0.50f;
            }

        }

        public void HienThi()
        {

            Console.WriteLine("{0,10} {1,20} {2,20} {3,20} {4,20} {5,20}", Sbd, HoTen, DiemVan, DiemAnh, KhuVuc, DiemUT);
            Console.WriteLine();
        }

        public override float TongDiem()
        {
            return base.TongDiem() + DiemUT;
        }

        public void XetTuyen(float diemsan)
        {
            if (TongDiem() >= diemsan)
            {
                HienThi();
            }
            //else
            //{
            //    Console.WriteLine("Ban Da Thi Truot");
            //}
        }
    }
    static void Main(string[] args)
    {
        List<ThiSinhUT> DSThiSinh = new List<ThiSinhUT>();

        int lc;
        int n;
        while (true)
        {
            Console.Write("Nhap lua chon : ");
            lc = System.Int32.Parse(Console.ReadLine());
            switch (lc)
            {
                case 1:
                    {
                        Console.WriteLine("\n====== Nhap Thong Tin Sinh Vien =======\n");
                        Console.Write("Nhap So Luong Thi Sinh : ");
                        n = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            ThiSinhUT x = new ThiSinhUT();
                            x.Nhap();
                            DSThiSinh.Add(x);
                        }
                    }; break;
                case 2:
                    {
                        Console.WriteLine("\n===== Hien Thi Thong Tin Sinh Vien =====\n");
                        Console.WriteLine("{0,0} {1,20} {2,20} {3,20} {4,20} {5,20}", "So Bao Danh", "Ho Ten", "Diem Van", "Diem Anh", "Khu Vuc", "Diem Uu Tien");
                        foreach (ThiSinhUT value in DSThiSinh)
                        {
                            value.HienThi();
                        }
                    }; break;
                case 3:
                    {
                        float diemsan;
                        Console.Write("Nhap Diem San : ");
                        diemsan = System.Single.Parse(Console.ReadLine());
                        Console.WriteLine("\n======= Danh Sach Cac Thi Sinh Thi Do Tai Ky Thi =======\n");
                        Console.WriteLine("{0,0} {1,20} {2,20} {3,20} {4,20} {5,20}", "So Bao Danh", "Ho Ten", "Diem Van", "Diem Anh", "Khu Vuc", "Diem Uu Tien");
                        foreach (ThiSinhUT value in DSThiSinh)
                        {
                            value.XetTuyen(diemsan);
                        }
                    }; break;
                case 4:
                    {
                        string sbd;
                        Console.Write("Nhap So Bao Danh Tim Kiem : ");
                        sbd = Console.ReadLine();
                        Console.WriteLine("{0,0} {1,20} {2,20} {3,20} {4,20} {5,20}", "So Bao Danh", "Ho Ten", "Diem Van", "Diem Anh", "Khu Vuc", "Diem Uu Tien");
                        foreach (ThiSinhUT value in DSThiSinh)
                        {
                            if (value.Sbd == sbd)
                            {
                                value.HienThi();
                            }
                        }

                    }; break;
            }
        }
    }
}

