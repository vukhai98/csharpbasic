using System;

namespace Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Switch dang thieu 
            //int k = 10;
            //switch (k)
            //{
            //    case 3:
            //        Console.WriteLine("HowKteam");
            //        break;
            //    case 6:
            //        Console.WriteLine("Kteam");
            //        break;
            //    case 10:
            //        Console.WriteLine("Free Education");
            //        break;


            //}
            #endregion

            #region Switch dang du
            int k = 12;
            switch (k)
            {
                case 3:
                    Console.WriteLine("HowKteam");
                    break;
                case 6:
                    Console.WriteLine("Kteam");
                    break;
                case 10:
                    Console.WriteLine("Free Education");
                    break;
                default:
                    Console.WriteLine("Connecting  to HowKteam ....");
                    break;


            }

            #endregion

            Console.ReadKey();
        }
    }
}
