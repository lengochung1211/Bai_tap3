using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen N : ");
            if (kiemtra(int.Parse(Console.ReadLine())))
                Console.WriteLine("So nguyen chia het cho 3");
            else
                Console.WriteLine("So nguyen khong chia het cho 3");
              
            Console.ReadLine();
        
         }

        static bool  kiemtra(int N)
        {
            return (N % 3 == 0) ? true : false;
        }
    }
}
