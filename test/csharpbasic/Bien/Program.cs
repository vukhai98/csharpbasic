using System;

namespace Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * <Kiểu dữ liệu> <Tên biến> ;
             */

            int KieuSoNguyen = 5;
            float BienKieuSoThuc = 6.9f;
            string BienKieuChuoi = "HowKteam.com - Free Education";
            bool BienKieuLuanLy = true;
            char BienKieuKyTu = 'K';

            int aNum = 6;
            int bNum = 9;
            int cNum = aNum + bNum;

            // In gía trị của biến KieuSoNguyen ra màn hình => 5

            Console.WriteLine(" a + b = c : {0} + {1} = {2} ", aNum, bNum, cNum);
            Console.ReadKey();
         
            
        }
    }
}
// Biến là gì ?
// biến có thể thay đổi
/*
 * - Là một giá trị dữ liệu có thể thay đổi được
 * - Là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ
 * - Là thành phần cốt lõi của một ngôn ngữ lập trình
 */

// => Why ???
/*
 * - Lưu trữ dữ liệu và tái sử dụng 
 * - Thao tác với bộ nhớ một cách dễ dàng
 */
//==================================================

/* QUY TẮC ĐẶT BIẾN
 *
 * Tên biến là một chuỗi ký tự liên kết (không có khoảng trắng) và không chứa ký tự đặc biệt 
 * Tên biến không được đặt bằng tiếng việt
 * Tên biến không được bắt đầu bằng số
 * Tên biến không được trùng nhau
 * Tên biến không được trùng với từ khóa
 */

/*
 * Quy tắc lạc đà :
 * - Viết thường từ đầu tiên và viết hoa chữ cái đầu tiên của những  từ tiếp theo => howKteamFreeEducation
 * - Thường dùng cho private, protected;
 */

/*
 * Quy tắc pascal:
 * - Viết chữ cái đầu tiên mỗi từ => HowKteamFreeEducation
 * - Còn lại
 */

/*
 * Nên đặt tên ngắn gọn dễ hiểu , thể hiện rõ mục đích của biến
 * Có phân biệt chữ thường -> a<>A || Console.WriteLine() <> Console.WRITE.LINE();
 */

