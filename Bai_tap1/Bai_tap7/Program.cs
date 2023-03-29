using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so nguyen duong : ");
                n = int.Parse(Console.ReadLine());

            } while (n <= 0);
            Console.WriteLine("Tong cac so le tu 1 den N : {0}", tongSL(n));
            Console.ReadLine();


        }
        static int tongSL(int n)
        {
            int j = 0;
            for (int i=1; i<=n; i++)
            {
                if (i % 2 != 0)
                    j += i;
            }
            return j;
        }
    }
}
