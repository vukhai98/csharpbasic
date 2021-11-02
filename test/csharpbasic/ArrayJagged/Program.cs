using System;

namespace ArrayJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Khai báo 1 mảng jagged tên jarray và có 2 phần tử tương ứng với 2 mảng con 
             * mảng con thứ nhất là mảng có 3 phần tử.
             * mảng con thứ hai là mảng có 7 phần tử.
             */
            int[][] jarray =
            {
                new int[] {1 ,2, 3},
                new int[] {3, 4, 5, 6, 7, 8, 9}

            };
            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write("\t" + jarray[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            

        }
    }
}
