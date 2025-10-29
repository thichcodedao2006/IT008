using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            Console.Write("Nhap thang: ");
            while(true)
            {
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Loi dinh dang. Nhap lai: ");
                }
            }
            Console.Write("Nhap nam: ");
            while (true)
            {
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Loi dinh dang. Nhap lai: ");
                }
            }
            if (month<=0 || year<=0 || month >12)
            {
                Console.WriteLine("Thang khong hop le. Khong ton tai thang vua nhap.");
                return;
            }
            DateTime current = new DateTime(year, month, 1);
            int DayInMonth = DateTime.DaysInMonth(year, month); // Số ngày trong tháng
            int StartDay = (int)current.DayOfWeek; // Ngày bắt đầu là thứ mấy 
            int day = 0;
            int now = 1;
            Console.WriteLine("Month: " + month.ToString("00") + "/" + year.ToString("0000"));
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            while (now <= DayInMonth)
            {
                if (day < StartDay) Console.Write("    ");
                else
                {
                    if (day % 7 == 0) Console.WriteLine();
                    Console.Write("{0,3}", now);
                    Console.Write(" ");
                    now++;
                }
                day++;
            }



        }
        
    }
}
