using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    // Lop PhanSo
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            int n = 0;
            PhanSo[] array = new PhanSo[n];
            Console.WriteLine("============Menu============");
            Console.WriteLine("0: Nhap 2 phan so.");
            Console.WriteLine("1: Nhap mot day cac phan so.");
            Console.WriteLine("2: Xuat ra 2 phan so.");
            Console.WriteLine("3: Xuat ra day phan so.");
            Console.WriteLine("4: Tinh tong 2 phan so.");
            Console.WriteLine("5: Tinh hieu 2 phan so.");
            Console.WriteLine("6: Tinh tich 2 phan so.");
            Console.WriteLine("7: Tinh thuong 2 phan so.");
            Console.WriteLine("8: Tim phan so lon nhat trong day phan so.");
            Console.WriteLine("9: Sap xep cac phan so trong day tang dan.");
            Console.WriteLine("10: Thoat.");
            Console.WriteLine("============================");
            int choice;
            while (true)
            {
                Console.Write("Nhap lua chon: ");
                while (true)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Write("Loi. Moi nhap lai: ");
                    }
                }
                if (choice == 0)
                {
                    InputPhanSo(ref a);
                    InputPhanSo(ref b);
                }
                else if (choice == 1)
                {
                    InputPhanSoArray(ref array, ref n);
                }
                else if (choice == 2)
                {
                    Console.Write("Phan so thu nhat: ");
                    OutputPhanSo(a);
                    Console.WriteLine();
                    Console.Write("Phan so thu hai: ");
                    OutputPhanSo(b);
                    Console.WriteLine();
                }
                else if (choice == 3)
                {
                    OutputArray(array, n);
                }
                else if (choice == 4)
                {
                    Console.Write("Tong 2 phan so la: ");
                    OutputPhanSo(a + b);
                    Console.WriteLine();
                }
                else if (choice == 5)
                {
                    Console.Write("Hieu 2 phan so la: ");
                    OutputPhanSo(a - b);
                    Console.WriteLine();
                }
                else if (choice == 6)
                {
                    Console.Write("Tich 2 phan so la: ");
                    OutputPhanSo(a * b);
                    Console.WriteLine();
                }
                else if (choice == 7)
                {
                    Console.Write("Thuong 2 phan so la: ");
                    OutputPhanSo(a / b);
                    Console.WriteLine();
                }
                else if (choice == 8)
                {
                    FindMaxPhanSo(array, n);
                }
                else if (choice == 9)
                {
                    SortArray(ref array, n);
                } else if (choice == 10)
                {
                    break;
                } else Console.WriteLine("Lua chon khong hop le.");
            }
        }

        // Xuat ra 1 day phan so.
        static void OutputArray(PhanSo[] array, int n)
        {
            Console.WriteLine("Cac phan so trong day: ");
            for (int i=0;i<n;i++)
            {
                Console.Write($"Phan so thu {i+1}: ");
                OutputPhanSo(array[i]);
                Console.WriteLine();
            }
        }
        // Xuat 1 phan so 
        static void OutputPhanSo(PhanSo a)
        {
            int common = a.gcd(Math.Abs(a.Tu), Math.Abs(a.Mau));
            a.Tu /= common;
            a.Mau /= common;
            if (a.Tu * a.Mau > 0)
            {
                a.Tu = Math.Abs(a.Tu);
                a.Mau = Math.Abs(a.Mau);
            } else
            {
                a.Tu = Math.Abs(a.Tu);
                a.Mau = Math.Abs(a.Mau);
                a.Tu = -a.Tu;
            }
            Console.Write(a.Tu);
            if (a.Mau != 1) Console.Write("/" + a.Mau);
        }

        // Nhap 2 phan so
        static void InputPhanSo(ref PhanSo a)
        {
            Console.Write("Nhap tu cho phan so: ");
            while(true)
            {
                try
                {
                    a.Tu = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            Console.Write("Nhap mau so cho phan so: ");
            while (true)
            {
                try
                {
                    a.Mau = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }

        }

        // Nhap mot day phan so 
        static void InputPhanSoArray(ref PhanSo[] array, ref int n)
        {
            Console.Write("Nhap so luong phan tu trong day: ");
            while(true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0) Console.Write("Phai nhap so duong. Moi nhap lai: ");
                    else break;
                }
                catch
                {
                    Console.Write("Loi.Moi nhap lai: ");
                }
            }
            array = new PhanSo[n];
            for (int i=0;i<n;i++)
            {
                array[i] = new PhanSo();
                InputPhanSo(ref array[i]);
            }
        }

        // Tim phan so lon nhat trong day 
        static void FindMaxPhanSo(PhanSo[] array, int n)
        {
            if (n==0)
            {
                Console.WriteLine("Mang rong.");
                return;
            }
            PhanSo MaxPhanSo = new PhanSo();
            MaxPhanSo.Tu = -100000;
            for (int i=0;i<n;i++)
            {
                if (MaxPhanSo < array[i])
                {
                    MaxPhanSo = array[i];
                }
            }
            Console.Write("Phan so lon nhat trong day la: ");
            OutputPhanSo(MaxPhanSo);
            Console.WriteLine();
        }

        // Sap xep cac phan so trong day tang dan 
        static void SortArray(ref PhanSo[] array, int n)
        {
            for (int i=0;i<n;i++)
            {
                for (int j=i+1;j<n;j++)
                {
                    if (array[i] > array[j])
                    {
                        PhanSo tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }
    }
}
