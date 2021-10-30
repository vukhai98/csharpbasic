using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
        
                int Vertical = 20;
                int Horizontal = 50;
                char drawChar = '*';
                char insideChar = ' ';
                int countLoopVertical = 0;
                int countLoopHorizontal = 0;


                // Vẽ từ trên xuống
                while (countLoopVertical < Vertical)
                {

                    // khởi tạo lại giá trị countLoopHorizontal = 0 mỗi lần lặp mới
                    countLoopHorizontal = 0;

                    // Vẽ từ trái sang
                    while (countLoopHorizontal < Horizontal)
                    {

                        /*
                         * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                         * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                         * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                         * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                         * thì vẽ ra ký tự của hình chữ nhật
                         * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                        */

                        if (countLoopVertical % (Vertical - 1) == 0 || ((countLoopVertical % (Vertical - 1) != 0) && (countLoopHorizontal % (Horizontal - 1) == 0)))
                        {
                            Console.Write(drawChar);    // lúc này là ký tự *
                        }
                        else
                        {
                            Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                        }


                        // tăng giá trị của countLoopHorizontal lên 1 đơn vị
                        countLoopHorizontal++;
                    }

                    // mỗi lần vẽ xong một hàng thì xuống dòng
                    Console.WriteLine();


                    // tăng giá trị của countLoopVertical lên 1 đơn vị
                    countLoopVertical++;
                }
                Console.ReadKey();
         }
    }
}
