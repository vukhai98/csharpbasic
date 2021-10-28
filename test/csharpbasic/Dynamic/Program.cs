using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Đặc điểm của kiểu  dynamic :
            // Khai báo stringValue kiểu dynamic và khởi tạo giá trị một chuỗi kiểu string 

            dynamic stringValue = " HowKteam";

            /*
             * Kiểu chuỗi sẽ không hỗ trợ toán tử ++
             * Nhưng câu lệnh stringValue ++ vẫn không báo lỗi do ở thời điểm hiện tại trình biên dịch vẫn chưa xác định kiểu dữ liệu cho biến stringValue
             * Khi chạy chương trình thì mới biết stringValue là kiểu string nên ko thể thực hiện được toán tử ++ lúc đó sẽ xuất hiện lỗi
             */
            stringValue++;

            Console.ReadKey();
            
           #endregion

        }
    }
}
