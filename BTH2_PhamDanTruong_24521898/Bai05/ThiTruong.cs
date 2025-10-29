using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    abstract class ThiTruong
    {
        protected string DiaDiem;
        protected int GiaBan;
        protected double DienTich;
        protected void InfoInput()
        {
            Console.Write("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            while(true)
            {
                try
                {
                    GiaBan = Convert.ToInt32(Console.ReadLine());
                    if (GiaBan < 0) Console.Write("So am. Moi nhap lai: ");
                    else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            Console.Write("Nhap dien tich: ");
            while(true)
            {
                try
                {
                    DienTich = Convert.ToDouble(Console.ReadLine());
                    if (DienTich < 0f) Console.Write("So am. Moi nhap lai: ");
                    else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
        }

        protected void InfoOutput()
        {
            Console.WriteLine("Dia diem cua khu vuc nay: " + DiaDiem);
            Console.WriteLine("Gia ban cua khu vuc nay: " + GiaBan);
            Console.WriteLine("Dien tich cua khu vuc nay: " + DienTich);
        }
        public abstract void Input();
        public abstract void Output();
        public abstract int GiaKhuDat();

        public abstract int GiaNhaPho();
        public abstract int GiaChungCu();

        public abstract bool Valid();

        public abstract bool Possible(string location, int price, double area);
    }
}
