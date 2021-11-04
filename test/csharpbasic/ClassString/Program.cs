using System;

namespace ClassString
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            string result = "";
            Console.Write(" Moi ban nhap ten minh :");
            fullName = Console.ReadLine();
            // cắt khoẳng trắng dư ở đầu và cuối chuỗi 
            fullName = fullName.Trim();
            // thực hiện tìm và thay thế 2 khoảng trắng or nhiều hơn thành 1 khoảng trắng 
            while (fullName.IndexOf("  ")  != -1)
            {
                fullName = fullName.Replace(" ", " ");
            }
            /*
             * Cắt chuỗi họ tên ra thành các mảng từ.
             * Sau đó  duyệt mảng để chuẩn hóa từng từ một ,
             * Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu tiên và lưu vào trong biếng FirstChar
             * Các chữ còn lại lưu vào biến OtherChar 
             * Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
             * cuối cùng là lưu trữ và chuẩn hóa vào biến result
             */

            string[] subName = fullName.Split(' '); 

            for (int i = 0; i < subName.Length; i++)
            {
                string firstChar = subName[i].Substring(0, 1);
                string otherChar = subName[i].Substring(1);
                subName[i] = firstChar.ToUpper() + otherChar.ToLower();
                result += subName[i] + " ";
            }
            Console.WriteLine("Ho ten cua ban la :{0}", result);
            Console.ReadKey();

        }
    }
}
