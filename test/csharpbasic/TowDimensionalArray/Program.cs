using System;

namespace TowDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 :
            //int[,] intArray = new int[9, 10];
            ///*
            // * Sử dụng 2 vòng for lồng vào nhau để duyệt mảng 2 chiều 
            // *Loop ngoài là loop duyệt mỗi dòng của two dimensional array
            // * với mỗi rows thì loop trong là vòng lặp duyệt các phần tử trên dòng trên dòng đó ( duyệt từng cột hiện tại)
            // */
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        /*
            //         * với cách duyệt này thì intArray [i,j] sẽ là phần tử hiện tại đang xét
            //         * code để xử lý viết ở đây
            //         */
            //    }

            //}    
            #endregion
            #region Example 2 :
            Console.WriteLine("Moi ban nhap so dong cua mang:");
            int rows = 0;
            int colums = 0;
            bool flagRows = true;
            bool flagColums = true;
            while (flagRows)
            {
                string strValue = Console.ReadLine();
                bool isSuccess = int.TryParse(strValue, out rows);
                if (isSuccess)
                {
                    flagRows = false;
                }
                else
                {
                    Console.WriteLine("Moi ban nhap lai ");
                }
            }
            Console.WriteLine("Moi ban nhap so cot cua mang:");
            while (flagColums)
            {
                string strValue = Console.ReadLine();
                bool isSuccess = int.TryParse(strValue, out colums);
                if (isSuccess)
                {
                    flagColums = false;
                }
                else
                {
                    Console.WriteLine("Moi ban nhap lai ");
                }
            }

            // Tạo 1 mảng 2 chiều với số dòng và số cột đã nhập

            int[,] intArray = new int[rows, colums];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write("Moi ban nhap phan tu intArray[{0}, {1}] =", i, j);
                    intArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            Console.WriteLine("\n Mang ban nhap la :");
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write(intArray[i, j] + " ");
                    sum = sum + intArray[i, j];

                }

                Console.WriteLine();
            }
            Console.WriteLine(" Tong cac gia tri trong mang: {0} ", sum);



            Console.ReadLine();
            #endregion

        }
    }
}
