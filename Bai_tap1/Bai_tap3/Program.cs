using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap gia tri N de tinh tong:");
            Console.WriteLine("Tong tu 1 den N la : {0}", tong(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }

        static int tong(int N)
        {
            int j = 0;
            for (int i = 1; i <= N; j += i, i++) ;
            return j;
        }
    }
}
