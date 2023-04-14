using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    private string MSV;
    private string HoTen;
    private string Lop;

    public Student(string mSV, string hoTen, string lop)
    {
        this.MaSV = mSV;
        this.HT = hoTen;
        this.LopHoc = lop;
    }

    public string MaSV
    {
        get => MSV;
        set => MSV = value;
    }

    public string HT
    {
        get => HoTen;
        set => HoTen = value;
    }

    public string LopHoc
    {
        get => Lop;
        set => Lop = value;
    }

    public void InTT()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ma Sinh Vien : " + MSV);
        Console.WriteLine("Ho Ten : " + HoTen);
        Console.WriteLine("Lop : " + Lop);
        Console.ForegroundColor = ConsoleColor.Black;
    }
}

