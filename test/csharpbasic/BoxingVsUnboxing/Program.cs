using System;

namespace BoxingVsUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Howkteam.com";
            /*
             * boxing : chuyển từ dữ liệu giá trị sang kiểu giữ liệu sang tham chiếu
             * 
             */
            int value = 100;
            object objectValue = value;
            int newValue = (int)objectValue;



            Console.ReadKey();
        }
    }
}
