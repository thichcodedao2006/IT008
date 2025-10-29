using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class KhuDat:ThiTruong
    {
        public override void Input()
        {
            Console.WriteLine("Nhap thong tin khu dat: ");
            InfoInput();
        }

        public override void Output()
        {
            Console.WriteLine("Thong tin khu dat: ");
            InfoOutput();
        }

        public override int GiaChungCu()
        {
            return 0;
        }

        public override int GiaKhuDat()
        {
            return GiaBan;
        }

        public override int GiaNhaPho()
        {
            return 0;
        }

        public override bool Valid()
        {
            if (DienTich > 100) return true;
            return false;

        }

        public override bool Possible(string location, int price, double area)
        {
            return false;
        }
    }
}
