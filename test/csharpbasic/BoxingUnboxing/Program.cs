using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing
            //int value = 100; // Khởi tạo biến value kiểu int(kiểu dữ liệu giá trị )
            ///*
            // * Thực hiện boxing bằng cách :
            // * Khởi tạo đối tượng objectValue kiểu object
            // * Gán giá trị của biến value vào objectValue
            // */
            //object objectValue = value;
            #endregion

            #region Unboxing
            int value = 100;
            // boxing 
            object objectValue = value;
            /* Unboxing bằng cách :
             * kiểm tra dữ liệu kiểu ObjectValue thấy thuộc kiểu int;
             * gắn giá trị của biến objcetValue vào biến NewValue bằng cách ép kiểu tường minh
             * biến newValue sẽm mang giá trị là 100
             */
            int newValue = (int)objectValue;
            Console.WriteLine(newValue);
            Console.ReadKey();
            #endregion


        }
    }
}
