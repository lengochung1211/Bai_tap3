using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap9
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

            tamgiac(n);
            Console.WriteLine("---------------------------");
            tamGiacNguoc(n);
            Console.WriteLine("---------------------------");
           
            Console.ReadKey();

        }
        static void tamgiac(int N)
        {
            string m = "*";
            for (int i = 1; i <= N; i++, m += "*")
            {
                Console.WriteLine(m);
            }
        }
        static void tamGiacNguoc(int N)
        {
            
            for (int i = N; i >= 1; i--)
            {
                string m = "*";
                for (int j = 1; j < i; j++, m += "*") ;
                
                    Console.WriteLine(m);
                
            }
     
        }
      
          
        }
}
