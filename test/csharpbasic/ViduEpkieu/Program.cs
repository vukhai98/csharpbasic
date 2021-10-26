using System;

namespace ViduEpkieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int tong, hieu, tich;
            double thuong;
            string strA, strB;

            Console.WriteLine("             ******************************************");
            Console.WriteLine("                                                     **");
            Console.WriteLine("             Chuong trinh tinh tong, hieu, tich, thuong");
            Console.WriteLine("             ******************************************");
            Console.Write("\n Moi ban nhap so A: ");
            strA = Console.ReadLine();
            Console.Write("Moi ban nhap so  B: ");
            strB = Console.ReadLine();

            a = int.Parse(strA);
            b = int.Parse(strB);

            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = a / b;

            Console.WriteLine("tong =" + tong);
            Console.WriteLine("hieu =" + hieu);
            Console.WriteLine("tich  =" + tich);
            Console.WriteLine("thuong=" + thuong);
            Console.ReadKey();






        }
    }
}
