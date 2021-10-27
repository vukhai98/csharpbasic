using System;

namespace ExampleSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int year; // bien chua gia tri cua nam can tinh 
            string can = "", chi = ""; // bien chua ket qua
            Console.WriteLine("Moi ban nhap mot nam bat ky :");
            year = Int32.Parse(Console.ReadLine()); // Nhap nam duong lich va ep kieu ve kieu so nguyen
             switch ( year % 10)
            {
                case 0:
                    can = "Canh";
                 
                    break;
                case 1:
                    can = "Tan";
                    break;
                case 2:
                    can = "Nham";
                    break;
                case 3:
                    can = "Quy";
                    break;
                case 4:
                    can = "Giap";
                    break;
                case 5:
                    can = "At";
                    break;
                case 6:
                    can = "Binh";
                    break;
                case 7:
                    can = "Dinh";
                    break;
                case 8:
                    can = "Mau";
                    break;
                case 9:
                    can = "Ky";
                    break;

            }

            switch (year % 12)
            {
                case 0:
                    chi = "Than";
                    break;
                case 1:
                    chi = "Dau";
                    break;
                case 2:
                    chi = "Tuat";
                    break;
                case 3:
                    chi = "Hoi";
                    break;
                case 4:
                    chi = "Ty";
                    break;
                case 5:
                    chi = "Suu";
                    break;
                case 6:
                    chi = "Dan";
                    break;
                case 7:
                    chi = "Mao";
                    break;
                case 8:
                    chi = "Thin";
                    break;
                case 9:
                    chi = "Ty";
                    break;
                case 10:
                    chi = "Ngo";
                    break;
                case 11:
                    chi = "Mui";
                    break;



            }
            Console.WriteLine("Nam {0} co nam am lich la : {1} {2}", year, can, chi);
            Console.ReadKey();
        }
    }
}
