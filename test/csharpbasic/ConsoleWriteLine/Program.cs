using System;

namespace ConsoleWriteLine
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
 
        static void Main(string[] args)
        {
            #region dfgdfg

            int a = 1;
            int b = 2;
            int c = a + b;
            int d = c + b;

            #endregion


            Console.Write("Kteam \n"); // Sử dụng ký tự đặc biệt để xuống dòng
            Console.WriteLine(5); // Sử dụng lệnh in ra màn hình có xuống dòng
            Console.Write(6.5f); // In ra giá trị nhưng ko xuống dòng
            Console.Write(Environment.NewLine); // Sử dụng lệnh xuống dòng
            Console.Write(true);

            Console.ReadKey(); // Đợi người dùng ấn Enter

        }
    }
}
