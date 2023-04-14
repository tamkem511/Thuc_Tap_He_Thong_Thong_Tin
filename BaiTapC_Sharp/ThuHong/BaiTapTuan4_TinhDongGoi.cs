using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    private int ID;
    private string Name;
    private int Age;
    private string Hometown;

    public Student(int iD, string name, int age, string hometown)
    {
        this.ID = iD;
        this.Name = name;
        this.Age = age;
        this.Hometown = hometown;
    }

    public void Output()
    {
        Console.WriteLine($"ID          Ho Ten          Tuoi          Ngay Sinh ");
        Console.WriteLine($"{ID}        {Name}        {Age}        {Hometown}");
    }

    public void setName(string newName)
    {
        if (newName.Length > 0 && newName.Length < 20)
        {
            this.Name = newName;
        }
        else
        {
            Console.WriteLine("Ho Ten Khong Hop Le !");
        }
    }

    public string getName()
    {
        return this.Name;
    }
}

