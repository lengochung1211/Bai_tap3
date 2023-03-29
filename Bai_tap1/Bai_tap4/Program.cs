using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            do
            {
                Console.Write("Nhap vao so nguyen duong N :");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

                if (kiemtra(n))
                    Console.WriteLine("N la so chinh phuong");
                else
                    Console.WriteLine("N khong phai la so chinh phuong");
                Console.ReadKey();
            
        }

        static bool kiemtra(int N)
        {
            if (Math.Pow(((int)Math.Sqrt(N)), 2) == N)
                return true;
            else
                return false;
        }
    }
}
