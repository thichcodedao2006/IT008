using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap n
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
                    Console.Write("Loi. Nhap lai: ");
                }
            }
            Console.WriteLine("So nhap hop le. Moi nhap mang: ");

            // Nhap mang
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                while (true)
                {
                    try
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Write($"Loi. Nhap lai phan tu thu {i + 1}: ");
                    }
                }
            }

            // Nhap lua chon cho menu
            Console.WriteLine("================Menu================");
            Console.WriteLine("0: Thoat");
            Console.WriteLine("1: In mang");
            Console.WriteLine("2: Tinh tong cac so le trong mang");
            Console.WriteLine("3: Dem so nguyen to trong mang");
            Console.WriteLine("4: Tim so chinh phuong nho nhat");
            Console.WriteLine("====================================");
            while (true)
            {
                Console.Write("Moi ban nhap lua chon: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                        break;
                    if (choice == 1)
                    {
                        Ouput(array, n);
                    }
                    else if (choice == 2)
                    {
                        Total_Odd_Func(array, n);
                    }
                    else if (choice == 3)
                    {
                        Counting_Prime_Func(array, n);
                    }
                    else if (choice == 4)
                    {
                        ChinhPhuongNhoNhat_Func(array, n);
                    }
                    else Console.WriteLine("Lua chon khong hop le.");
                }
                catch
                {
                    Console.WriteLine("Loi");
                }

            }
        }

        static void Total_Odd_Func(int[] array, int n)
        {
            int Total_odd = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Total_odd += array[i];
                }
            }
            Console.WriteLine($"Tong cac so le trong mang la: {Total_odd}");
        }

        static void Counting_Prime_Func(int[] array, int n)
        {
            int Prime_count = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(array[i]))
                {
                    Prime_count++;
                }
            }
            Console.WriteLine("So luong so nguyen to trong mang la: " + Prime_count);
        }

        static void ChinhPhuongNhoNhat_Func(int[] array, int n)
        {
            int smallest = -1;
            for (int i = 0; i < n; i++)
            {
                if (ChinhPhuong(array[i]))
                {
                    if (smallest == -1)
                        smallest = array[i];
                    else
                        smallest = Math.Min(smallest, array[i]);
                }
            }
            Console.WriteLine("So chinh phuong nho nhat trong mang la: " + smallest);
        }
        static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return n > 1;
        }

        static bool ChinhPhuong(int n)
        {
            int half = (int)Math.Sqrt(n);
            if (half * half == n)
                return true;
            return false;
        }

        static void Ouput(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
