using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so tu nhien n: ");
            int n;
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch
                {
                    Console.Write("Loi. Nhap lai so n: ");
                }
            }
            int Total_Prime = 0;
            for (int i = 1; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Total_Prime += i;
                }
            }
            if (Total_Prime == 0)
            {
                Console.WriteLine($"Khong ton tai so nguyen to < {n}.");
                return;
            }
            Console.WriteLine($"Tong cac so nguyen to < {n} la: {Total_Prime}");
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return n > 1;
        }
    }
}
