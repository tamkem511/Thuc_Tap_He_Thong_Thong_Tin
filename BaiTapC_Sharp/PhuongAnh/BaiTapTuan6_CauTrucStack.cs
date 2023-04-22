using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Stack x = new Stack();

        x.Push(2);
        x.Push(4);
        x.Push(1);
        x.Push(6);
        x.Push(9);


        foreach (var item in x)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        // Peek() : Dung De Lay Phan Tu Tren Cung Nhung Khong Xoa
        Console.WriteLine(x.Peek());

        //Pop() : Dung De Xoa Phan Tu Tren Cung
        Console.WriteLine(x.Pop());

        foreach (var item in x)
        {
            Console.Write(item + " ");
        }

        x.Clear();

        Console.WriteLine("==== Danh Sach Stack sau khi Xoa ====");
        foreach (var item in x)
        {
            Console.Write(item + " ");
        }
    }
}

