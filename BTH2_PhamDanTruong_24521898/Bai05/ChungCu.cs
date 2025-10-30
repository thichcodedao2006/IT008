using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class ChungCu: ThiTruong
    {
        private int SoTang;

        public override void Input()
        {
            Console.WriteLine("Nhap thong tin cho chung cu: ");
            InfoInput();
            Console.Write("Nhap so tang: ");
            while(true)
            {
                try
                {
                    SoTang = Convert.ToInt32(Console.ReadLine());
                    if (SoTang <= 0)
                    {
                        Console.Write("So am. Moi nhap lai: ");

                    } else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
        }

        public override void Output()
        {
            Console.WriteLine("Thong tin khu chung cu: ");
            InfoOutput();
            Console.WriteLine("So tang: " + SoTang);
        }

        public override int GiaChungCu()
        {
            return GiaBan;
        }

        public override int GiaKhuDat()
        {
            return 0;
        }

        public override int GiaNhaPho()
        {
            return 0;
        }

        public override bool Valid()
        {
            return false;
        }

        public override bool Possible(string location, int price, double area)
        {
            string current = DiaDiem.ToLower();
            location = location.ToLower();
            bool have = current.Contains(location);
            if (have && GiaBan <= price && DienTich >= area) return true;
            return false;
        }
    }
}
