using System;

namespace EpKieuTrong_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryParseExact
            //https://stackoverflow.com/questions/11999912/datetime-tryparseexact-rejecting-valid-formats
            //https://www.c-sharpcorner.com/blogs/enforcing-date-pattern-with-datetimetryparseexact-method


            #region Chuyển đổi kiểu ngầm định

            //int k = 10;
            //long l = k; //Chuyển đổi ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int;
            //float f = 10.9f;
            //double d = f; //Tương tự vì kiểu double có miền giá trị lớn hơn float ;



            #endregion

            #region Chuyển đổi kiểu tường minh
            //int i = 300; //300 có mã nhị phân là 100101100

            //byte b = (byte)i; //do kiểu byte có giới hạn đến 255 nên ko chứa được 300 nên ta phải đổi sang kiểu int;

            //Console.WriteLine("i = " +i);

            //Console.WriteLine(" b = " +b);

            //double d= 2 / 3; // kết quả là 0 vì 2 chia 3 đều là số nguyên nên phần dư là 0;
            //double k= (double)2 / 3; // ép kiểu số từ số nguyên sang số thực ;
            //double t = 1.0 * 2 / 3; // Thực hiện nhân 1.0 với mục đích biến 2 số nguyên thàn 2.0 số thực;

            //Console.WriteLine("d = {0} \n k= {1} \n t= {2} ", d, k, t);






            //Console.ReadKey();




            #endregion

            #region Parse ()
            //string s = "10";
            //int k = int.Parse(s); // Chuyển chuỗi s sang kiểu int và lưu giá trị vào biến k -> Kết quả k=10.
            //double e = double.Parse("10.9"); // Chuyển chuỗi giá trị hằng "10.9" sang kiểu  int và lưu giá trị vào biến e -> e = 10.9 ;


            #endregion

            #region TryParse()
            //int result; // Biến chứa giá trị kết quả khi ép kiểu thành công
            //bool isSuccess; // Biến kiểm tra việc ép kiểu có thành công hay không
            //string data1 = "10", data2 = "Kteam"; // Dữ liệu cần ép kiểu

            //isSuccess = int.TryParse(data1, out result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ mang giá trị 
            //Console.Write(isSuccess == true ? "Success !" : "Failed !");
            //Console.WriteLine("result =" + result); // In giá trị ra màn hình.
            //isSuccess = int.TryParse(data2, out result);
            //Console.Write(isSuccess == true ? "Success !" :" Failed !");
            //Console.WriteLine("result =" + result);
            //Console.ReadKey();
           
            int rows,colums;
            
            bool flag1,flag2;
            while (flag1 = false)
            {
                string a = Console.ReadLine();
                bool isSuccess = int.TryParse(a, out rows);
                if (isSuccess)
                {
                    flag1 = true;
                }
                else
                {
                    Console.WriteLine("ban nhap lại");
                }
            }

            while (flag2 = false)
            {
                string a = Console.ReadLine();
                bool isSuccess = int.TryParse(a, out colums);
                if (isSuccess)
                {
                    flag2 = true;
                }
            }
            #endregion

            #region Convert

            #endregion





        }
    }
}
/*
 * Chuyển đổi ngầm định
 * Chuyển đổi tường minh
 * Sử dụng phương thức, lớp hỗ trợ sẵn => Parse(),TryParse(); Convert
 * Người dùng tự định nghĩa kiểu chuyển đổi 
 */


