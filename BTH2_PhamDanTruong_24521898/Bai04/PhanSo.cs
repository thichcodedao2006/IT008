using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class PhanSo
    {
        private int tu, mau;
        public PhanSo()
        {
            this.tu = 0;
            this.mau = 1;
        }
        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }

        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }

        public int gcd(int x, int y)
        {
            while (y > 0)
            {
                int tmp = y;
                y = x % y;
                x = tmp;

            }
            return x;
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo sum = new PhanSo();
            int x = a.Tu * b.Mau + a.Mau * b.Tu;
            int y = a.Mau * b.Mau;
            int common = a.gcd(Math.Abs(x), Math.Abs(y));
            x /= common;
            y /= common;
            sum.Tu = x;
            sum.Mau = y;
            return sum;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo sub = new PhanSo();
            int x = a.Tu * b.Mau - a.Mau * b.Tu;
            int y = a.Mau * b.Mau;
            int common = a.gcd(Math.Abs(x), Math.Abs(y));
            x /= common;
            y /= common;
            sub.Tu = x;
            sub.Mau = y;
            return sub;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo mul = new PhanSo();
            int x = a.Tu * b.Tu;
            int y = a.Mau * b.Mau;
            int common = a.gcd(Math.Abs(x), Math.Abs(y));
            x /= common;
            y /= common;
            mul.Tu = x;
            mul.Mau = y;
            return mul;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo divide = new PhanSo();
            int x = a.Tu * b.Mau;
            int y = a.Mau * b.Tu;
            int common = a.gcd(Math.Abs(x), Math.Abs(y));
            x /= common;
            y /= common;
            divide.Tu = x;
            divide.Mau = y;
            return divide;
        }

        public static bool operator >(PhanSo a, PhanSo b)
        {
            if (a.Tu * a.Mau > 0)
            {
                a.Tu = Math.Abs(a.Tu);
                a.Mau = Math.Abs(a.Mau);
            }
            else
            {
                a.Tu = Math.Abs(a.Tu);
                a.Mau = Math.Abs(a.Mau);
                a.Tu = -a.Tu;
            }
            if (b.Tu * b.Mau > 0)
            {
                b.Tu = Math.Abs(b.Tu);
                b.Mau = Math.Abs(b.Mau);
            }
            else
            {
                b.Tu = Math.Abs(b.Tu);
                b.Mau = Math.Abs(b.Mau);
                b.Tu = -b.Tu;

            }
            return (a.Tu * b.Mau > b.Tu * a.Mau);
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            if (a.Tu * a.Mau > 0)
            {
                a.Tu = Math.Abs(a.Tu);
                a.Mau = Math.Abs(a.Mau);
            }
            else
            {
                a.Tu = Math.Abs(a.Tu);
                a.Mau = Math.Abs(a.Mau);
                a.Tu = -a.Tu;
            }
            if (b.Tu * b.Mau > 0)
            {
                b.Tu = Math.Abs(b.Tu);
                b.Mau = Math.Abs(b.Mau);
            }
            else
            {
                b.Tu = Math.Abs(b.Tu);
                b.Mau = Math.Abs(b.Mau);
                b.Tu = -b.Tu;

            }
            return (a.Tu * b.Mau < b.Tu * a.Mau);
        }
    }
}
