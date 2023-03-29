using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap10
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
            Console.WriteLine("Day so Fibonacci la : ");
            fib(n);
            Console.ReadKey();

        }
        static void fib(int N)
        {
            int a =0, b=1;
            for (int i=1 ; i<=(int)N/2; i++)
            {
                Console.Write($"{a}\t{b}\t");
                a += b;
                b += a;
            }
        }
    }
}
