using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bai02
{
    class Program
    {
        static void ShowFileAndDirectory(string path)
        {
            try
            {
                string[] directory = Directory.GetDirectories(path);
                string[] file = Directory.GetFiles(path);
                foreach (string s in file)
                {
                    Console.WriteLine(s);
                }
                foreach (string s in directory)
                {
                    Console.WriteLine(s);
                    ShowFileAndDirectory(s);
                }
            }
            catch
            {
                Console.WriteLine("Khong the truy cap.");
            }
        }
        static void Main(string[] args)
        {
            string path;
            Console.Write("Nhap duong dan thu muc ban muon: ");
            while(true)
            {
                path = Console.ReadLine();
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Danh sach cac thu muc con va tap tin: ");
                    ShowFileAndDirectory(path);
                    break;
                }
                Console.Write("Duong dan khong ton tai. Moi nhap lai: ");
            }
        }
    }
}
