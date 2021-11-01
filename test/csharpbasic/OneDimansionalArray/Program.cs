using System;

namespace OneDimansionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cú pháp khai báo , khởi tạo , cấp pháp vùng nhớ , khởi tạo giá trị cho mảng 
            // Cu phap mang 1 chieu :

            // <kiểu dữ liệu> [] <tên mảng> = new <kiểu dữ liệu> [] { giá trị 1, ... ,giá trị n }

            /*
             * Khai báo mảng 1 chiều kiểu string và có tên là Kteam.
             * Sau đó thực hiện cáp phát vùng nhớ với số phần tử tối đa là 3
             */
            //string[] Kteam = new string[3];

            /*
             * Khởi tạo giá trị ngay khi cấp vùng nhớ.
             * Sau câu lệnh này thì mảng Kteam sẽ có  2 phần tử  mang giá trị là " HowKteam" và " Free Education"
             */
            //string[] kteam = new string[] { "HowKteam", "Free Education" };
            //int[] Intarray = { 1, 2, 3 };
            //Console.WriteLine(Intarray[1]);




            #endregion

            #region Example 1 :
            //int year; // Biến chứa giá trị năm cần tính 
            //// Mảng Can chứa các giá trị can tương uwsnsg thep bảng can 

            //string[] can = { "Canh", " Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            //// Mảng Chi chứ các giá trị  chi tương ứng theo bảng chi

            //string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };

            //Console.Write("Nhap nam bat ky :");

            //// Nhập năm dương lịch cần tính và ép kiểu trả về số nguyên  

            //year = Int32.Parse(Console.ReadLine());

            ///*
            // * Vì kết quả phép chia lấy dư của year%10 hoặc  yerar % 12 sẽ cho ra số nguyên
            // * Nên ta dùng nó làm chỉ số phần tử để tra cứu ra giá trị can chi tương tứng . Thay vì dùng swith case
            // * Như vầy cách này vừa đơn giản và dễ hiểu hơn swith
            // */
            //Console.WriteLine(" Nam {0} co nam am lich la : {1} {2}", year, can[year % 10], chi[year % 12]);
            //Console.ReadKey();
            #endregion

            #region Example 2 :
            string[] hoTenSinhVien = new string[4];
            for (int i = 0; i < hoTenSinhVien.Length; i++)
            {
                hoTenSinhVien[i] = Console.ReadLine();

            }
            Console.WriteLine();
            for (int i = 0; i < hoTenSinhVien.Length; i++)
            {
                Console.WriteLine(hoTenSinhVien[i]);
            }
            Console.ReadLine();

            #endregion


        }
    }
}