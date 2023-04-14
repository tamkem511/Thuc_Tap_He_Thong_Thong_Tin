using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	internal class Bai4_2
	{
		static void Main(string[] args)
		{
			int n;
			Console.Write("Nhap n : ");
			n = Convert.ToInt32(Console.ReadLine());
			int[] a = new int[n];

			Console.WriteLine("==== Nhap Mang ====");
			for (int i = 0; i < n; i++)
			{
				Console.Write($"Nhap a[{i}] : ");
				a[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("==== Xuat Mang ====");
			for (int i = 0; i < n; i++)
			{
				Console.Write(a[i] + " ");
			}

			//Sap Xep
			Array.Sort(a);

			int max = a[0];
			int max2 = a[0];
			int vt = 0;
			for (int i = 1; i < n; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
					vt = i;
				}
			}


			for (int i = 0; i < vt; i++)
			{
				if (a[i] > max2)
				{
					max2 = a[i];
				}
			}

			Console.WriteLine("Max2 = " + max2);
		}
	}

