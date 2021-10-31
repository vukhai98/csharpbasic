using System;

namespace BasicFunction
{
    class Program
    {
        static void Main(string[] args)
        #region Example 1
        //{
        //    // Gọi lại hàm nhiều lần 
        //    // dòng chữ Called from Demo ! HowKteam.com cũng được in ra nhiều lần
        //    Demo();
        //    Demo();
        //    Demo();
        //    Demo();

        //    Console.ReadKey();
        //}
        //static void Demo ()
        //{
        //    Console.WriteLine("Called from Demo! HowKteam.com");
        //}
        #endregion
        #region Example 2
        //// <sumary>
        ///*
        // * Hàm trả về giá trị số nguyên 5 thông qua tên hàm
        // * lưu ý giá trị trả về phải cùng kiểu dữ liệu với hàm
        // */
        //{

        //    Demo();
        //    Console.ReadKey();
        //}
        //static int ReturnANumber()
        //{
        //    // bắt buộc phải có cấu trúc return trong thân hàm
        //    return 5;
        //}
        //static void Demo()
        //{
        //    Console.WriteLine(ReturnANumber());
        //}

        #endregion
        #region Example 3
        //{
        //    int firstNum = 0;
        //    int secondNum = 0;
        //    // in ra man hình 10 lần  tổng của 2 số 
        //    for ( int count = 0; count < 10; count++ )
        //    {
        //        // in ra màn hình tổng 2 số 
        //        PrintSumTwoNumber(firstNum, secondNum);
        //        // tính toán để ra cặp số ngẫu nhiên 
        //        firstNum += count;
        //        secondNum += count * 2 % 5;

        //    }
        //    Console.ReadKey();
        //}


        //static void PrintSumTwoNumber (int firstNumber , int secondNumber)
        //{
        //    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, SumTowNumber(firstNumber,secondNumber));
        //}
        //// hàm trả về kết quả của 2 số  firsNumber và secondNumber 
        //static int SumTowNumber( int firstNumber , int secondNumber)
        //{
        //    return firstNumber + secondNumber;
        //}

        #endregion
        #region Example 4
        {
            PrintSomeThing("Vu Minh Khai ", 23);
            PrintSomeThing("HowKteam.com", 2);
            Console.ReadKey();
        }
        static void PrintSomeThing (string name , int age)
        {
            Console.WriteLine(" This is {0} , {1} years old .", name, age);
        }

        #endregion
    }
}
