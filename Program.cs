using System;

namespace Bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten");
            String name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi");
            String diachi = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai");
            String phone = Console.ReadLine();

            Console.WriteLine("Thong tin nguoi dung");
            Console.WriteLine("Ho ten : " + name);
            Console.WriteLine("Dia chi : " + diachi);
            Console.WriteLine("Phone : " + phone);
        }
    }
}
