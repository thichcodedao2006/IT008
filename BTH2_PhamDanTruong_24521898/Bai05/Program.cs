using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            ThiTruong[] PhanMem = new ThiTruong[n]; 
            Console.WriteLine("      PHAN MEM QUAN LY");
            Console.WriteLine("============Menu============");
            Console.WriteLine("1: Nhap thong tin cac khu vuc.");
            Console.WriteLine("2: Xuat thong tin cac khu vuc.");
            Console.WriteLine("3: Xuat tong gia ban cho tung loai khu vuc.");
            Console.WriteLine("4: Xuat danh sach cac khu vuc thoa man dieu kien de ra.");
            Console.WriteLine("5: Tim kiem khu vuc thoa.");
            Console.WriteLine("6: Thoat.");
            Console.WriteLine("============================");
            int choice;
            while(true)
            {
                Console.Write("Moi nhap lua chon: ");
                while(true)
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
                if (choice == 1)
                {
                    NhapThongTin(ref PhanMem, ref n);
                }
                else if (choice == 2)
                {
                    XuatThongTin(PhanMem, n);
                }
                else if (choice == 3)
                {
                    TongTien(PhanMem, n);
                }
                else if (choice == 4)
                {
                    Validate(PhanMem, n);
                }
                else if (choice == 5)
                {
                    FindLocation(PhanMem, n);
                }
                else if (choice == 6)
                {
                    break;
                }
                else Console.WriteLine("Lua chon khong hop le. Moi chon lai: ");

            }
        }

        // Nhap thong tin cho tung khu vuc
        static void NhapThongTin(ref ThiTruong[] PhanMem, ref int n)
        {
            Console.Write("Nhap so luong khu vuc quan ly: ");
            while(true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.Write("Moi nhap lai: ");
                    } else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            PhanMem = new ThiTruong[n];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine($"Nhap thong tin cho khu vuc thu {i + 1}: ");
                int type;
                Console.Write("Nhap loai khu vuc (1: Khu Dat    2: Nha Pho    3: Chung Cu): ");
                while (true)
                {
                    while (true)
                    {
                        try
                        {
                            type = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.Write("Loi. Moi nhap lai: ");
                        }
                    }
                    if (type == 1)
                    {
                        PhanMem[i] = new KhuDat();
                        break;
                    }
                    if (type == 2)
                    {
                        PhanMem[i] = new NhaPho();
                        break;
                    }
                    if (type == 3)
                    {
                        PhanMem[i] = new ChungCu();
                        break;
                    }
                    Console.Write("Lua chon khong hop le. Moi nhap lai: ");
                }
                PhanMem[i].Input();
            }
        }

        // Xuat thong tin cho tung khu vuc
        static void XuatThongTin(ThiTruong[] PhanMem, int n)
        {
            if (n==0)
            {
                Console.WriteLine("Danh sach rong.");
                return;
            }
            Console.WriteLine("Thong tin cac khu vuc phan mem quan ly: ");
            for (int i=0;i<n;i++)
            {
                Console.WriteLine($"Thong tin khu vuc thu {i+1}: ");
                PhanMem[i].Output();
            }
        }

        static void TongTien(ThiTruong[] PhanMem, int n)
        {
            int TienKhuDat = 0, TienNhaPho = 0, TienChungCu = 0;
            for (int i=0;i<n;i++)
            {
                TienKhuDat += PhanMem[i].GiaKhuDat();
                TienNhaPho += PhanMem[i].GiaNhaPho();
                TienChungCu += PhanMem[i].GiaChungCu();
            }
            Console.WriteLine("Tong tien cua cac khu vuc la khu dat: " + TienKhuDat);
            Console.WriteLine("Tong tien cua cac khu vuc la nha pho: " + TienNhaPho);
            Console.WriteLine("Tong tien cua cac khu vuc la chung cu: " + TienChungCu);
        }

        // Xuat danh sach cac khu vuc thoa ma yeu cau de bai
        static void Validate(ThiTruong[] PhanMem, int n)
        {
            if (n==0)
            {
                Console.WriteLine("Danh sach rong.");
                return;
            }
            List<ThiTruong> MyVector  = new List<ThiTruong>();
            for (int i=0;i<n;i++)
            {
                if (PhanMem[i].Valid())
                {
                    MyVector.Add(PhanMem[i]);   
                }
            }
            if ((int)MyVector.Count > 0)
            {
                Console.WriteLine("Danh sach cac khu vuc thoa: ");
                foreach (ThiTruong t in MyVector)
                {
                    t.Output();
                }
                return;
            }
            Console.WriteLine("Khong co khu vuc nao thoa dieu kien.");
        }

        // Tim kiem danh sach cac khu vuc theo dia diem, gia va dien tich
        static void FindLocation(ThiTruong[] PhanMem, int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Danh sach rong.");
                return;
            }
            string location;
            int price;
            double area;
            Console.Write("Nhap dia diem muon tim: ");
            location = Console.ReadLine();
            Console.Write("Nhap gia muon tim: ");
            while (true)
            {
                try
                {
                    price = Convert.ToInt32(Console.ReadLine());
                    if (price < 0) Console.Write("So am. Moi nhap lai: ");
                    else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            Console.Write("Nhap dien tich muon tim: ");
            while (true)
            {
                try
                {
                    area = Convert.ToDouble(Console.ReadLine());
                    if (area < 0f) Console.Write("So am. Moi nhap lai: ");
                    else break;
                }
                catch
                {
                    Console.Write("Loi. Moi nhap lai: ");
                }
            }
            List<ThiTruong> PossibleLocation = new List<ThiTruong>();
            for (int i=0;i<n;i++)
            {
                if (PhanMem[i].Possible(location, price, area))
                {
                    PossibleLocation.Add(PhanMem[i]);
                }
            }
            if ((int)PossibleLocation.Count>0)
            {
                Console.WriteLine("Danh sach cac nha pho va chung cu thoa yeu cau: ");
                foreach (ThiTruong t in PossibleLocation)
                {
                    t.Output();
                }
                return;
            }
            Console.WriteLine("Khong co khu vuc nao thoa yeu cau can tim.");
        }
    }
}
