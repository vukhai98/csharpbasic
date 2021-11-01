using System;

namespace KeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            IncreaseValue( out  value);
            Console.WriteLine(" Value after increase: {0}", value);
            Console.ReadLine();
        }
        static void IncreaseValue (out  int value)
        {
            value = 1998;
            value++;
        }
        /*
         * Vùng nhớ của các parametter sẽ được hàm sử dụng  trực tiếp dẫn đến khi kết thúc  lời gọi hàm giá trị của các parametter có thể bị thay đổi
         * Phải có từ khóa out trước tên parametter của hàm và trước tên biến truyền vào khi gọi sử dụng hàm 
         * biến truyền vào có từ khóa out sẽ không cần khởi tạo giá trị ban đầu
         * Parametter dó chỉ như 1 thùng chứ kết quả chả về khi kết thúc gọi hàm 
         * Đồng thời Parametter đó phải được khởi tạo ngay bên trong lời gọi hàm .
         */
    }
}
