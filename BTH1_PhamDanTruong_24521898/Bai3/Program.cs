using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            Console.Write("Nhap ngay: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thang: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = Convert.ToInt32(Console.ReadLine());
            bool Valid = ValidDate(day,month,year);
            if (Valid) Console.WriteLine($"Ngay {day}/{month}/{year} la mot ngay hop le.");
            else Console.WriteLine($"Ngay {day}/{month}/{year} la mot ngay KHONG hop le.");
        }
        static bool NamNhuan(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 != 0) return true;
            return false;
        }
        static bool ValidDate(int day, int month, int year)
        {
            if (day > 31 || day<=0 || month > 12 || month<=0) return false;
            switch(month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if (day > 31) return false;
                    break;
                case 4: case 6: case 9:
                case 11:
                    if (day > 30) return false;
                    break;
                case 2:
                    if (NamNhuan(year))
                    {
                        if (day > 29) return false;
                    } else
                    {
                        if (day > 28) return false;
                    }
                    break;
            }
            return true;
        }
    }
}
