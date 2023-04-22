using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[7] { 1, 6, 9, 2, 3, 4, 5 };
        IEnumerable<int> query = from x in num
                                    where (x % 2) == 0
                                    orderby x ascending
                                    select x;
        foreach (int i in query)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n=== truy van theo phuong thuc mo rong ===\n");

        var query2 = num.Take(5).Where(x => (x % 2) != 0).OrderBy(x => x).Select(x => x);
        foreach (int i in query2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n=== tinh tong ===\n");
        int s = num.Sum();
        Console.WriteLine(s);

        Console.WriteLine("\n=== tim max ===\n");
        int m = num.Max();
        Console.WriteLine(m);

        Console.WriteLine("\n=== chua chuoi con ===\n");
        bool y = num.Contains(9);
        Console.WriteLine(y);

        Console.WriteLine("\n=== Lay ra nhung so lon hon 5 ===\n");
        IEnumerable<string> value = from vl in num
                                    where vl > 5
                                    orderby vl ascending
                                    select $"So Lon Hon 5 : {vl}";
        foreach (var v in value)
        {
            Console.WriteLine(v);
        }

        Console.WriteLine("\n=== Dem Xem Co Bao Nhieu So Nho Hon 5===\n");
        int countValue = (from n in num
                            where n < 5
                            select n).Count();
        Console.WriteLine($"So Luong : {countValue}");
    }
}

