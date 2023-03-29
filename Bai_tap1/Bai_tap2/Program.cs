using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong bang cuu chuong:");
            cuuChuong(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }

        static void cuuChuong(int N)
        {
            for (int k = 1; k<= N; k++)
            { 
                for (int i = 1, j = k; i <= 10; i++, j += k)
                {
                Console.WriteLine("{0} X {1}\t= {2}", k, i, j);
                }
                Console.WriteLine("----------------------------");
            }
        }
    }
}
