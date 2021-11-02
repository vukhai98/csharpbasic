using System;

namespace ThreeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Khởi tạo và cấp giá trị threeDimensionalArray
            //int[,,] threeDimensionalArray = new int[,,]
            //{
            //   {
            //       {1, 2, 3 },
            //       {4, 5, 6 }
            //   },
            //   {
            //       {7, 8, 9 },
            //       {10, 11, 12 }
            //   }
            //};
            //Console.WriteLine(threeDimensionalArray[0, 0, 0]);
            //Console.ReadKey();
            #endregion

            #region Cách duyệt mảng 3 chiều
            int[,,] intArray = new int[3, 9, 10];
            for (int i = 0; i <intArray.GetLength(0); i++)
            {
                for (int j = 0; j <intArray.GetLength(1) ; j++)
                {
                    for (int k = 0; k <intArray.GetLength(2); k++)
                    {
                        Console.Write("\t" + intArray[i, j, k]);
                        /*
                         * Với cách duyệt này thì intArray [i,j,k] là phần tử hiện tại mình đang xét 
                         * Code xử lý sẽ viết ở đây 
                         */
                    }
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}
