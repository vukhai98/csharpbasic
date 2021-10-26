using System;

namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1
            //int a, b, c;
            //a = b = (c = 9) + 1; // Khởi tạo giá trị của a = 10 , b = 10 , c = 9;


            //a += b; // tương đương a = a+b;
            //b = c++; // thực hiện gắn giá trị c cho biến b sau đó c = c + 1;
            //--c; //  thực hiện c = c-1;
            //Console.WriteLine(" a = {0}, b = {1} , c = {2}", a, b, c);

            //Console.ReadKey();







            #endregion

            #region Vi du 2

            string strSoNguyen; // Biến chứa dữ liệu nhập vào từ bàn phím 
            int Songuyen; // Biến chứa số nhập vào từ bàn phím
            string KetQua; //Biến chứa kết quả kiểm tra số vừa nhập là chẵn hay lẻ
            strSoNguyen = Console.ReadLine(); // Đọc dữ liệu nhập vào từ bàn phím (dữ liệu dạng chuỗi) sau đó gắn giá trị vào strSoNguyen;
            Songuyen = Int32.Parse(strSoNguyen);// Ép kiểu dữ liệu vừa nhập vào (dạng chuỗi ) sang dạng số rồi gắn giá trị vào biến SoNguyen;
            KetQua = (Songuyen % 2 == 0) ? "so chan" : " so le";// Sử dụng toán tử 3 ngôi để kiểm tra số chan số lẻ
            Console.WriteLine("{0} la {1}", Songuyen, KetQua); // In ket qua ra man hinh

            Console.ReadKey();






            #endregion


        }
    }
}