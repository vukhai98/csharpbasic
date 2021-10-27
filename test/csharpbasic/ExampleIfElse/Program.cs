using System;

namespace ExampleIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB;
            int A, B;
            double Nghiem;
           
            Console.WriteLine("Chuong trinh giai phuong trinh Ax + B = 0");
            Console.WriteLine("Moi ban nhap so A :");
            strA = Console.ReadLine();
            Console.WriteLine("Moi ban nhao so b :");
            strB = Console.ReadLine();
            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine("Du lieu nhap sai !");

            }
            else
            {
                Console.WriteLine("\n Phuong trinh cua ban vua nhap la :{0}x + {1} = 0", A, B);
                if (A==0)
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem !");

                }
                else if (B==0)
                {
                    Console.WriteLine("\n Phuong trinh co nghiem x = 0");


                }
                else
                {
                    Nghiem = (double)-B / A;
                    Console.WriteLine("\n Phuong trinh co nghiem x = {0} ", Nghiem);
                }

                       
            }
        }


       
    }
}
