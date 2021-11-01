using System;

namespace LocalvariableAndGlobalvariable
{
    class Program
    {
        #region Example 1
        //static int value = 5;
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(value);
        //    value = 10;
        //    PrintSomeThing();
        //    Console.ReadKey();


        //}
        //static void PrintSomeThing()
        //{
        //    int value = 18;
        //    Console.WriteLine(value);
        //}
        #endregion

        #region Example 2
        static void Main(string[] args)
        {
            bool isTrue = false;
            if ( isTrue)
            {
                int value = 5;
                Console.WriteLine(value);
            }
            else
            {
                int value = 3;
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
        /*
         *  local variable chỉ tồn tại trong tầm vực của {} , khi tầm vực ko  thúc thì local variabel cũng kết thục 
         *  global variable cũng tồn tại trong {} nhưng có thể dùng từ đầu tới cuối của lớp class ss
         */

        #endregion 
    }
}
