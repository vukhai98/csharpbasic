using System;

namespace ConsoleRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.Read()); // đọc 1 ký tự từ bàn phím bằng lệnh Console.Read() sau đó in ra ký tự vừa đọc ( bảng mã askey)
            //Console.ReadKey(); // lệnh này dùng với mục đích dừng màn hình để xem kết quả.

            //Console.WriteLine(Console.ReadLine()); // đọc dữ liệu từ bàn phím cho đến khi gặp ký tự xuống dòng thì dừng. Sau đó in giá trị để nhập ra màn hình
            //Console.ReadKey(); // lệnh dùng với mục đích dừng màn hình để xem kết quả


            Console.WriteLine("Kteam");
            Console.ReadKey(); // không truyền tham số vào thì mặc định là false
            Console.ReadKey(false); // hiển thị phím bạn nhập trên màn hình.
            Console.ReadKey(true); //không hiển thị phím bạn nhập  nên màn hình.


        }
    }
}
