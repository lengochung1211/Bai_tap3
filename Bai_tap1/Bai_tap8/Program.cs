using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap8
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
            } while (n < 2);

            for (int i = 2; i <= n; i++)
            {
                if (kiemtra(i))
                    Console.Write("{0}\t", i);

            }
            
            Console.ReadKey();

        }

        static bool kiemtra(int N)
        {
            int j = 0;
            for (int i=2; i<=(int)Math .Sqrt (N); i++)
            {
                if (N % i == 0)
                    j++;
            }
            if (j == 0)
                return true  ;
            else
                return false  ;

        }
    }
}
