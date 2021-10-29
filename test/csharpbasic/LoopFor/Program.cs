using System;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vi du 1 

            //// i sẽ được khởi tạo lần đầu tiên tại vòng lặp for
            //// khi vòng đời của vòng lặp for kết thúc bố  nhớ của biến i sẽ được giải phóng
            //// hay nói cách khác i là biến cục bộ của vòng lặp for 


            //for(int i =0; ; )
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadKey();

            #endregion
            #region Vi du 2 
            //int i;
            //// i được gắn giá trị bằng 0
            //// i lúc này không phải biến cục bộ của hàm for
            //// i thuộc hàm main

            //for (i =  0; ;)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Vidu 3
            //int i; 
            //for (i =0;(i % 3 == 0) && (i<10) ;)
            //{
            //    Console.WriteLine(i);
            //    i++;

            //}
            #endregion
            #region Vi du 4 
            //int i;
            //int j = 0;

            //for (i = 0; i < 10; i++, j += 3, console.writeline("tăng"))
            //{
            //    console.writeline(i);

            //}
            #endregion
            #region Vi du 5
            int n = 20;
            int m = 30;

            char drawChar = '@';
            char insideChar = '*';
            // Vẽ từ trên xuống 
            for (int i = 0; i < n; i++)
            {
                // vẽ từ trái sang
                for (int j = 0; j < m; j++)
                {
                     if (i % (n - 1)==0 || ((i % (n  - 1) !=0) && (j % (m - 1)==0)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(drawChar); // lúc này vẽ char *
                        
                    } 
                     else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(insideChar); // lúc này là ký tự rỗng   ''
                    }    
                }
                Console.WriteLine(); // mỗi lần xong 1 hàng thì xuống dòng

            }
            Console.ReadKey();

                     
              

            #endregion
           
        }
    }
}
