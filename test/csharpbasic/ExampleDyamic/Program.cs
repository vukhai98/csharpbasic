using System;

namespace ExampleDyamic
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " HowKteam";
            string mission = "Free Education";// khai báo  2 biến name va mission kiểu string và khởi tạo giá trị
            /*
             *  Thực hiện gán 1 kiểu string cho biến dynamic bằng cách ép kiểu ngầm định
             *  Sau phép gán thì biến Dynamicvalue chứa cả giá trị  nhưng kiểu dữ liệu  của nó vẫn chưa được xác định
             */

            dynamic dynamicname = name;

            // Thực hiện cộng chuối in ra màn hình bình thường 


            Console.WriteLine(" Mission of " + dynamicname + " is " + mission);
            Console.ReadKey();
            



        }
    }
}
