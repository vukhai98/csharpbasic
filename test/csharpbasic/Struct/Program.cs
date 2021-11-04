using System;

namespace Struct
{
    class Program
    {
           struct Student
        {
            public int studentCode;
            public string name ;
            public double diemToan ;
            public double diemVan;
            public double diemLy;
        }

        static void NhapThongTinStudent( out  Student sd)
        {
            Console.Write("studentCode :");
            sd.studentCode = int.Parse(Console.ReadLine());
            Console.Write("Name :");
            sd.name = Console.ReadLine();
            Console.Write("Diem Toan :");
            sd.diemToan = double.Parse(Console.ReadLine());
            Console.Write("Diem Van :");
            sd.diemVan = double.Parse(Console.ReadLine());
            Console.Write("Diem Ly :");
            sd.diemLy = double.Parse(Console.ReadLine());

        }
        static void XuatThongTinStudent (Student sd)
        {
            Console.WriteLine("Studen code :" + sd.studentCode);
            Console.WriteLine("Name :" + sd.name);
            Console.WriteLine("Diem Toan : " + sd.diemToan);
            Console.WriteLine("Diem Van  :" + sd.diemVan);
            Console.WriteLine("Diem Ly :" + sd.diemLy);
        }
        static double StudentIsGPA (Student sd)
        {
            return (sd.diemToan + sd.diemVan + sd.diemLy) / 3;
        }
        static void    Main(string[]agrs)
        {
            Student sd1= new Student();
            Console.WriteLine(" Nhap thong tin Student :");
            NhapThongTinStudent(out sd1);
            Console.WriteLine("********");
            Console.WriteLine("Thong tin Student vua nhap la :");
            XuatThongTinStudent(sd1);
            Console.WriteLine("Diem trung binh cua Student la : " + StudentIsGPA(sd1));
            Console.ReadKey();
        }
       
    }
}
