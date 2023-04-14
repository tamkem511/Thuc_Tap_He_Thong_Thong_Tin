using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        //float[] Marks = { 2.4f, 5, 6.7f, 8, 5.6f, 9 };
        //float Math = 9.8f;
        //float English = 8;
        //float Bio = 6.5f;
        //float Ltt = 9;
        //Console.WriteLine(Sum(Math,English,Bio,Ltt));

        int[] a = { 2, 3, 6, 8, 7, 9 };
        float[] b = { 2.5f, 8.9f, 6.7f };
        int x = 5;
        int y = 9;
        int z = 12;
        int m = 3;
        Console.WriteLine("Min : " + Min(x, y, z, m));
        Console.WriteLine(Sum(b));
    }

    static double Sum(params float[] Marks)
    {
        double S = 0;
        foreach (var item in Marks)
        {
            S += item;
            ;
        }
        return S;
    }

    static int Min(params int[] a)
    {
        int min = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        return min;
    }
}

