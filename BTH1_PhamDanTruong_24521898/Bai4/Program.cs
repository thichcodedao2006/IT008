using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            Console.Write("Nhap thang: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (month >= 0 && month <= 12 && year >= 0)
            {
                int NumberDay = NumbDay(month, year);
                Console.WriteLine($"So ngay trong thang ban vua nhap la: {NumberDay}");
            }
            else Console.WriteLine("Ngay nhap khong hop le. Khong ton tai thang vua nhap.");
            
        }

        static bool NamNhuan(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) return true;
            return false;
        }
        static int NumbDay(int month,int year)
        {
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                case 4: case 6: case 9: case 11:
                    return 30;
                case 2:
                    if (NamNhuan(year)) return 29;
                    return 28;
            }
            return 0;
        }
    }
}
