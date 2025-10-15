using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
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
            bool IsValid = ValidDate(day, month, year);
            if (IsValid)
            {
                DateTime InputDate = new DateTime(year, month, day);
                string Day = InputDate.DayOfWeek.ToString();
                Day = Chuyen(Day);
                Console.WriteLine($"Thu trong tuan ban vua nhap la: {Day}");
            }
            else
            {
                Console.WriteLine("Ngay vua nhap la ngay khong hop le. Khong ton tai ngay.");
            }    
        }

        static bool NamNhuan(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 != 0) return true;
            return false;
        }
        static bool ValidDate(int day, int month, int year)
        {
            if (day > 31 || day<=0 || month > 12 || month<=0 || year <0) return false;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 31) return false;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30) return false;
                    break;
                case 2:
                    if (NamNhuan(year))
                    {
                        if (day > 29) return false;
                    }
                    else
                    {
                        if (day > 28) return false;
                    }
                    break;
            }
            return true;
        }

        static string Chuyen(string day)
        {
            string t = "";
            switch(day)
            {
                case "Monday":
                    t = "Thu Hai";
                    break;
                case "Tuesday":
                    t = "Thu Ba";
                    break;
                case "Wednesday":
                    t = "Thu Tu";
                    break;
                case "Thursday":
                    t = "Thu Nam";
                    break;
                case "Friday":
                    t = "Thu Sau";
                    break;
                case "Saturday":
                    t = "Thu Bay";
                    break;
                case "Sunday":
                    t = "Chu Nhat";
                    break;
            }
            return t;
        }
    }
}
