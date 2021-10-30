using System;


namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vi du 1
            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;
            //int minRandomValue = 0;
            //int maxRandomValue = 100;

            //Random rand = new Random();

            //// Vẽ từ trên xuống loopTime lần
            //while (countLoopTime < loopTime)
            //{
            //    // reset lại biến cuontLoop về 0 để viết lại từ đầu 
            //    countLoop = 0;
            //    // vẽ từ trái qua value lần
            //    while (countLoop < valueNum)
            //    {
            //        // giá trị ngẫu nhiên từ khoảng min tới max-1
            //        int showValue = rand.Next(minRandomValue, maxRandomValue);

            //        // in ra giá trị countLoop trong  8 vị trí 

            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.Write("{0,8}", showValue);

            //        // tăng giá trị của biến countLoop nên 1 đơn vị 
            //        countLoop++;
            //    }
            //    // mỗi khi hoàn thành xong 1 vòng lặp nhỏ thì lại xuống dòng chuẩn bị cho lần tiếp theo
            //    Console.WriteLine();
            //    // tăng giá trị của biến countLoopTime nên 1 đơn vị 
            //    countLoopTime++;




            //}
            //Console.ReadKey();
            #endregion
            #region Vi du 2
            int vertical = 20;
            int horizontal = 50;
            char drawChar = '@';
            char insideChar = '*';
            int countLoopVertical = 0;
            int countLoopHorizontal = 0;
            // vẽ trên xuống 
            while (countLoopVertical < vertical) 
            {
                // khởi tạo giá trị countLoopHorizontal = 0 mỗi lần lặp lại
                countLoopHorizontal = 0;
                while (countLoopHorizontal < horizontal)
                {
                    if (countLoopVertical % (vertical - 1) == 0 || ((countLoopVertical % (vertical - 1) != 0) && (countLoopHorizontal % (horizontal - 1) == 0)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(drawChar); // in kí tự  *
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(insideChar); // in kí tự rỗng
                    }
                    // tăng giá trị của countLoopHorizontal lên 1 đơn vị
                    countLoopHorizontal++;

                }
                // mỗi lần vẽ xong  một hàng thì xuống dòng

                Console.WriteLine();

                // tăng giá trị của cuontVertial nên 1 đơn vị 

                countLoopVertical++;

            }
            
            Console.ReadKey();
            #endregion

        }
    }
}
