using System;

namespace ConsoleWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kteam \n"); // Sử dụng ký tự đặc biệt để xuống dòng
            Console.WriteLine(5); // Sử dụng lệnh in ra màn hình có xuống dòng
            Console.Write(6.5f); // In ra giá trị nhưng ko xuống dòng
            Console.Write(Environment.NewLine); // Sử dụng lệnh xuống dòng
            Console.Write(true);

            Console.ReadKey(); // Đợi người dùng ấn Enter

        }
    }
}
