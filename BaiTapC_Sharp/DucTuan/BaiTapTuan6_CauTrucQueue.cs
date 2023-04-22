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


        Queue<int> x = new Queue<int>();

        x.Enqueue(2);
        x.Enqueue(5);
        x.Enqueue(1);
        x.Enqueue(7);
        x.Enqueue(9);
        x.Enqueue(8);

        foreach (int item in x)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Phan Tu Co The Bi Xoa : " + x.Peek());

        x.Dequeue();
        Console.WriteLine("==== Danh Sach Sau Khi Xoa ====");
        foreach (var item in x)
        {
            Console.Write(item + " ");
        }
        {

        }


    }
}

