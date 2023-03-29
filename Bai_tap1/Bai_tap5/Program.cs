using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int soThang;
            do
            {
                Console.Write("Nhap so thang tu 1 den 12 : ");
                soThang = int.Parse(Console.ReadLine());
            } while (soThang < 1 || soThang > 12);
            tinhNgay(soThang);

            Console.ReadLine();
        }
        static void  tinhNgay(int soThang)
        {
            switch (soThang)
            {
                case 2:
                    Console.WriteLine("Thang co 28 hay 29 ngay. ");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine("Thang co 30 ngay. ");
                    break;
                default:
                    Console.WriteLine("Thang co 31 ngay.");
                    break;
            }

        }
    }
}
