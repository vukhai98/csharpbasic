using System;

namespace ExerciseDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      Kteam"); // In chữ " Kteam " sau đó xuống dòng .
            Console.Write(" Moi ban nhap ten cua minh :"); // In chữ ra ko xuống dòng.
            Console.WriteLine(" Ten cua ban la :" + Console.ReadLine());
            // Quy tắc chung trong thực hiện lệnh là lệnh bên trong trước rồi đến lệnh bên ngoài chứa nó
            // Do đó chạy đến đây chương trình sẽ thực hiên lệnh Console.ReadLine() sau đó thực hiện chuối và cuối cùng in ra màn hình .
            Console.Write(" Moi ban nhap ngay sinh cua minh:");
            Console.WriteLine("Ngay sinh cua ban la:" + Console.ReadLine()); // tương tự như trên.
            Console.Write(" Moi ban nhap que quan :");
            Console.WriteLine("Que quan cua ban :" + Console.ReadLine()); // tương tự như trên.


            Console.ReadKey();
        }
            

     }
}
