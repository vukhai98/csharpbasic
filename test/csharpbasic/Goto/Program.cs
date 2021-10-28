using System;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vi du 1
            //int a = 2;
            ////switch (a)
            //{
            //    case 1:  // lable case 1
            //        console.writeline(" case 1 ");
            //        break;
            //    case 2: // lable  case 2
            //        console.writeline(" case 2 ");
            //        goto case 1; // dich chuyen den  lable 1
            //        break;
            //    case 3:  // lable case 3
            //        console.writeline(" case 3 ");
            //        break;





            //}
            #endregion
            #region Vi du 2
            //int a = 2;

            //if (a==2) // neu a = 2
            //{

            //    goto a_Is_2; // dich chuyen toi label a_Is_2
            //}
            //Console.WriteLine("A==1");

            //a_Is_2:
            //Console.WriteLine("A==2");


            #endregion
            #region Vi du 3
            //    int a =2;
            //Infinity_Loop:
            //    if (a == 2) // nếu a = 2
            //    {
            //        goto a_Is_2; // dich chuyển tới label a_Is_2
            //    }
            //    Console.WriteLine("A==1");
            //a_Is_2:
            //    Console.WriteLine("A==2");
            //    goto Infinity_Loop; // dich chuyển tới label Infinity_Loop


            #endregion

            string howKteamstr = "HowKteam.com";
            int count = 0;
        beginLoop:
            Console.WriteLine(howKteamstr);
            count++;
            if (count < 1000)
                goto beginLoop;
            Console.WriteLine(" End Loop");

            Console.ReadKey();
        }
    }
}
