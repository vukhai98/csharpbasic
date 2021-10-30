using System;

namespace Loopdowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VÍ DỤ 1 
            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;
            //// vẽ từ trên xuống loopTime lần 
            //do
            //{
            //    //reset lại biến countLoop về  0 để viết lại từ đầu
            //    countLoop = 0;
            //    while (countLoop < valueNum)
            //    {
            //        // in ra giá trị của countLoop trong  8 vị trí 
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.Write("{0,8}", countLoop);
            //        // tăng dần giá trị của countLopp  lên 1 đơn vị 
            //        countLoop++;
            //    }
            //    // mỗi lần viết xong 1 hàng thì xuống dòng 
            //    Console.WriteLine();
            //    // tăng dần giá trị của countLoopTime nên 1 đơn vị 
            //    countLoopTime++;



            //} while (countLoopTime < loopTime);
            //Console.ReadKey();
            #endregion
            #region VÍ DỤ 2
            int vertical = 20;
            int horizontal = 50;
           
            char drawChar = '@';
            char insideChar = '*';

            int countLoopVertical = 0;
            int countLoopHorizontal = 0;
            do
            {
                // khởi tạo giá trị của countHorizontal = 0;
                countLoopHorizontal = 0;
               
                // vẽ từ trái sang
                do
                {
                    if (countLoopVertical % (vertical - 1) == 0 || ((countLoopVertical % (vertical - 1) != 0) && (countLoopHorizontal % (horizontal - 1) == 0)))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(drawChar);


                    }
                   
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(insideChar);

                    }
                    // tăng giá trị của countLoopHorizontal nên 1 đơn vị
                    countLoopHorizontal++;


                } while (countLoopHorizontal < horizontal);
                // viết xong 1 dòng thì xuống dòng
                Console.WriteLine();
                //  tăng giá trị của countLoopVertical nên 1 đơn vị
                countLoopVertical++;


            } while (countLoopVertical < vertical);

            Console.ReadKey();

            #endregion

        }
    }
}
