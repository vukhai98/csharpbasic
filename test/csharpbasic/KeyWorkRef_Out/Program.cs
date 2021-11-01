using System;

namespace KeyWorkRef_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;

            Console.WriteLine(" Value before increase: {0} ", value);

            IncreaseValue(ref value);

            Console.WriteLine(" Value after increase: {0}", value);
            Console.ReadKey();
        }
      
        static void IncreaseValue( ref int value)
        {
         
            value++;
        }


    }
}
