using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Menu===============");
            Console.WriteLine("0: Nhap du lieu cho ma tran.");
            Console.WriteLine("1: Xuat ma tran.");
            Console.WriteLine("2: Tim kiem mot phan tu trong ma tran.");
            Console.WriteLine("3: Xuat cac phan tu la so nguyen to.");
            Console.WriteLine("4: Chi so cua dong co nhieu so nguyen to nhat.");
            Console.WriteLine("5: Thoat.");
            Console.WriteLine("==================================");
            int choice;
            int n = 0, m = 0;
            int[,] matrix = new int[n, m];
            while (true)
            {
                Console.Write("Nhap lua chon cua ban: ");
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
                    MatrixInput(ref matrix, ref n, ref m);
                }
                else if (choice == 1)
                {
                    MatrixOutput(matrix, n, m);
                }
                else if (choice == 2)
                {
                    FindElementInMatrix(matrix, n, m);
                }
                else if (choice == 3)
                {
                    PrimeElement(matrix, n, m);
                }
                else if (choice == 4)
                {
                    RowWithMostPrime(matrix, n, m);
                }
                else if (choice == 5)
                {
                    break;
                }
                else Console.WriteLine("Lua chon khong hop le.");
            }
        }
        // Nhap du lieu cho ma tran
        static void MatrixInput(ref int[,] matrix, ref int n, ref int m)
        {
            Console.Write("Nhap so dong: ");
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0) Console.Write("So dong khong hop le. Moi nhap lai: ");
                    else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            Console.Write("Nhap so cot: ");
            while (true)
            {
                try
                {
                    m = Convert.ToInt32(Console.ReadLine());
                    if (m <= 0) Console.Write("So cot khong hop le. Moi nhap lai: ");
                    else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            matrix = new int[n, m];
            Console.WriteLine("Nhap du lieu cho ma tran: ");
            for (int i=0;i<n;i++)
            {
                string s = Console.ReadLine();
                int[] array = s.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                for (int j=0;j<m;j++)
                {
                    matrix[i,j] = array[j];
                }
            }
        }

        // Xuat du lieu cho ma tran
        static void MatrixOutput(int[,] matrix, int n, int m)
        {
            if (n==0 && m==0)
            {
                Console.WriteLine("Ma tran rong.");
                return;
            }
            Console.WriteLine("Ma tran: ");
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Tim kiem mot phan tu trong ma tran
        static void FindElementInMatrix(int[,] matrix, int n, int m)
        {
            if (n==0 && m==0)
            {
                Console.WriteLine("Ma tran rong.");
                return;
            }
            int k;
            Console.Write("Nhap phan tu ban muon tim: ");
            while (true)
            {
                try
                {
                    k = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            int row =-1, col=-1;
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    if (matrix[i,j] == k)
                    {
                        row = i + 1;
                        col = j + 1;
                        break;
                    }
                }
            }
            if (row==-1 && col==-1)
            {
                Console.WriteLine("Khong ton tai phan tu trong ma tran.");
            } else
            {
                Console.WriteLine($"Vi tri cua phan tu do la: ({row}, {col})");
            }
        }

        static bool IsPrime(int k)
        {
            for (int i=2;i*i<=k;i++)
            {
                if (k % i == 0) return false;
            }
            return k > 1;
        }

        // Xuat cac phan tu la so nguyen to.
        static void PrimeElement(int[,] matrix, int n, int m)
        {
            if (n == 0 && m == 0)
            {
                Console.WriteLine("Ma tran rong.");
                return;
            }
            List<int> PrimeVector = new List<int>();
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    if (IsPrime(matrix[i,j]))
                    {
                        PrimeVector.Add(matrix[i,j]); 
                    }
                }
            }
            if ((int)PrimeVector.Count > 0)
            {
                Console.WriteLine("Cac so nguyen to trong ma tran. ");
                foreach (int prime in PrimeVector)
                {
                    Console.Write(prime + " ");
                }
                Console.WriteLine();
            } else Console.WriteLine("Khong ton tai so nguyen to trong ma tran.");
        }

        // Chi so dong co nhieu so nguyen to nhat.
        static void RowWithMostPrime(int[,] matrix, int n, int m)
        {
            if (n == 0 && m == 0)
            {
                Console.WriteLine("Ma tran rong.");
                return;
            }
            int MaxPrimeNumb = 0;
            int rowIndex = 0;
            for (int i=0;i<n;i++)
            {
                int cnt = 0;
                for (int j=0;j<m;j++)
                {
                    if (IsPrime(matrix[i,j]))
                    {
                        cnt++;
                    }
                }
                if (MaxPrimeNumb < cnt)
                {
                    rowIndex = i + 1;
                    MaxPrimeNumb = cnt;
                }
            }
            if (rowIndex == 0) Console.WriteLine("Khong ton tai so nguyen to trong ma tran.");
            else
            {
                Console.WriteLine($"Dong {rowIndex} co nhieu so nguyen to nhat.");
            }
        }
    }
}
