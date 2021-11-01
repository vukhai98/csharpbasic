using System;

namespace KeyWorkRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;

            Console.WriteLine("Value  before  increase:{0}", value) ;

            IncreaseValue( ref value);

            Console.WriteLine("Value after increase:{0}", value);
            Console.ReadKey();

        }
        static void IncreaseValue( ref int value)
        {
            value++;
        }
        /*
         * Từ khóa ref phải có trước parametter của hàm  và phải có trước tiên biến truyền vào khi gọi hàm để sử dụng
         * Truyền parametter có từ khóa ref bắt buộc phải là biến( không thể truyền vào một hằng số vì hằng có giá trị thay đổi)
         * Có thể có một hoặc nhiều parametter có từ khóa ref trong lời khai báo hàm  .
         * Biến truyền vào có từ khóa ref phải được khởi tạo giá trị trước khi truyền vào .
         * Hàm sử dụng thao tác trực tiếp với vùng nhớ của  các parametter trên RAM . Cho nên kết thúc lời gọi hàm giá trị  các parametter sẽ thay đổi 
         */
    }
}
