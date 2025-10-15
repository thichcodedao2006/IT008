using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Nhap so dong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] Matrix = new int[n, m];
            Console.WriteLine("Nhap du lieu cho ma tran: ");
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                int[] array = s.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                for (int j = 0; j < m; j++)
                {
                    Matrix[i, j] = array[j];
                }
            }
            Console.WriteLine("==============Menu==============");
            Console.WriteLine("0: Thoat chuong trinh.");
            Console.WriteLine("1: Xuat ma tran vua nhap.");
            Console.WriteLine("2: Xuat ra phan tu lon nhat va nho nhat trong ma tran.");
            Console.WriteLine("3: Xuat ra chi so dong co tong lon nhat.");
            Console.WriteLine("4: Xuat ra man hinh tong cac so khong phai la so nguyen to.");
            Console.WriteLine("5: Xuat ra man hinh ma tran khi da xoa dong thu k.");
            Console.WriteLine("6: Xuat ra man hinh ma tran sau khi da xoa cot co chua phan tu lon nhat.");
            Console.WriteLine("================================");
            while(true)
            {
                int choice;
                Console.Write("Moi ban nhap lua chon: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;
                if (choice == 1)
                {
                    Output(Matrix, n, m);
                } else if (choice == 2)
                {
                    Largest_Smallest_Func(Matrix, n, m);
                } else if (choice == 3)
                {
                    Row_With_Largest_Sum_Func(Matrix, n, m);
                } else if (choice == 4)
                {
                    Sum_Not_Prime_Func(Matrix, n, m);
                } else if (choice == 5)
                {
                    Delete_K_Row_Func(ref Matrix,ref  n, m);
                } else
                {
                    Delete_Column_MaxSum_Func(ref Matrix,n, ref m);
                }
            }
        }
        
        static void Delete_Column_MaxSum_Func(ref int[,] Matrix, int n,ref int m)
        {
            DeleteMaxValue(ref Matrix, n,ref m);
            Console.WriteLine("Ma tran sau khi xoa cac cot co phan tu lon nhat la: ");
            Output(Matrix, n, m);
        }
        static void Delete_K_Row_Func(ref int[,] Matrix,ref int n, int m)
        {
            Console.Write("Nhap dong muon xoa: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > n || k<=0)
            {
                Console.WriteLine("Khong hop le. Dong ban muon xoa khong nam trong ma tran.");
                return;
            }
            DeleteK(ref Matrix,ref n, m, k);
            Console.WriteLine($"Ma tran sau khi xoa dong thu {k} la: ");
            Output(Matrix, n, m);
        }
        static void Sum_Not_Prime_Func(int[,] Matrix, int n, int m)
        {
            int sum = 0;
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    if (!IsPrime(Matrix[i,j]))
                    {
                        sum += Matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu khong phai la so nguyen to la: " + sum);
        }
        static void Row_With_Largest_Sum_Func(int[,] Matrix, int n, int m)
        {
            int index = 0;
            int MaxSum = int.MinValue;
            for (int  i = 0; i < n;i++)
            {
                int sum = 0;
                for (int j=0;j < m;j++)
                {
                    sum += Matrix[i, j];
                }
                if (MaxSum < sum)
                {
                    MaxSum = sum;
                    index = i;
                }
            }
            index++;
            Console.WriteLine("Chi so dong co tong phan tu lon nhat la: " + index);
            Console.WriteLine("Tong cua dong nay la: " + MaxSum);
        }
        static void Largest_Smallest_Func(int[,] Matrix, int n, int m)
        {
            Console.WriteLine("Phan tu lon nhat trong ma tran la: " + GetMax(Matrix, n, m));
            Console.WriteLine("Phan tu nho nhat trong ma tran la: " + GetMin(Matrix, n, m));    
        }
        static void Output(int[,] Matrix, int n, int m)
        {
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Console.Write(Matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int GetMax(int[,] Matrix, int n, int m)
        {
            int MaxValue = int.MinValue;
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    MaxValue = Math.Max(MaxValue, Matrix[i,j]);
                }
            }
            return MaxValue;
        }

        static int GetMin(int[,] Matrix, int n, int m)
        {
            int MinValue = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    MinValue = Math.Min(MinValue, Matrix[i, j]);
                }
            }
            return MinValue;
        }

        static bool IsPrime(int n)
        {
            for (int i=2;i*i<=n;i++)
            {
                if (n % i == 0) return false;
            }
            return n > 1;
        }

        static void DeleteK(ref int[,] Matrix, ref int n, int m, int k)
        {
            k--;
            for (int i=k;i<n-1;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Matrix[i, j] = Matrix[i + 1, j]; 
                }
            }
            n--;
        }

        static void DeleteMaxValue(ref int[,] Matrix, int n, ref int m)
        {
            int MaxValue = GetMax(Matrix, n, m);
            bool[] IsDelete = new bool[m];
            for (int j=0;j<m;j++) IsDelete[j] = false;
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    if (Matrix[i,j]==MaxValue) IsDelete[j] = true;
                }
            }
            int _m = m;
            for (int j=0;j<m;j++)
            {
                if (IsDelete[j])
                {
                    _m--;
                }
            }
            int[,] NewMatrix = new int[n, _m];
            int index = 0;
            for (int j=0;j<m;j++)
            {
                if (IsDelete[j]) continue;
                for (int i=0;i<n;i++)
                {
                    NewMatrix[i, index] = Matrix[i,j];
                }
                index++;
            }
            m = _m;
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Matrix[i,j] = NewMatrix[i,j];
                }
            }
        }
    }
}
