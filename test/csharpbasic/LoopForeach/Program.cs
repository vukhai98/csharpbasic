using System;

namespace LoopForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 :
            //int[] intarray = { 1, 2, 3, 4, 5, 6 };
            //int sum = 0;
            //foreach (int item in intarray)
            //{
            //    Console.Write("\t" + item);
            //    sum += item;
            //}
            //Console.WriteLine("\n sum =" + sum);
            //Console.ReadKey();
            #endregion
            #region Example 2 :
            int[][] jaggedArray =
            {
                 new int[] {1, 2, 3},
                 new int[] {5, 2, 4, 1, 6},
                 new int[] {7, 3, 4, 2, 1, 5, 9, 8}
            };
            foreach (int[] element  in jaggedArray )
            {
                foreach (int item in element)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            #endregion
        }
    }
}
