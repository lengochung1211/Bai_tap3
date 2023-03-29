using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap6
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

            Console.WriteLine("Gia tri tong : {0}", tong(n));
            Console.ReadLine();

        }
        static double tong(int n)
        {
            double j = 0;
            for (int i = 1; i <= n; j += Math.Pow(i, i), i++) ;
            return (j);
                    
        }
    }
}
