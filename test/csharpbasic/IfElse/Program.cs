using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region lack type condition ( Điều kiện loại thiếu)
            //string k = "Kteam";
            //if(k == "Kteam")
            //Console.WriteLine("Free Education");
            //Console.ReadKey();
            #endregion

            #region sufficient condition ( Điều kiện loại đủ)
            string k = "HowKTeam";
            if (k == "HowKteam")
            {
                Console.WriteLine("Free Education");
            }
            else if( k == "Kteam")
            {
                Console.WriteLine("HowKteam.com");
                Console.WriteLine("Free Education");
            }
            else
            {
                if (k == "10-09")
                {
                    Console.WriteLine("Conntecting HowKteam....");
                }
                else
                {
                    Console.WriteLine(" Public website HowKteam.com");
                }
            }



            #endregion
            Console.ReadKey();

        }
    }
}
