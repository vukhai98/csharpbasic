using System;

namespace ToanTuGanVsKhoiTao
{
    class Program
    {
        static void Main(string[] args)
        {
            int H, K, T;
            H = K = T = 10;
            Console.WriteLine("{0} , {1} , {2} ", H, K, T);

            H += K = T = 5;
            Console.WriteLine("{0} , {1} , {2} ", H, K, T);

            Console.ReadKey();


        }



    }
}
