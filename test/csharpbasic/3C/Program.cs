

using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            //Regex reg = new Regex(@"\d");
            //Match result = reg.Match("-howkteam.com 10092016 -");
            //#region Match
            ////Console.WriteLine(result.ToString());

            //#endregion
            #region Match Collection
            //do
            //{
            //    Console.WriteLine(result.ToString());
            //    result = result.NextMatch();

            //} while (result != Match.Empty);
            #endregion
            #region  Match Collection 2
            //foreach (Match item in reg.Matches("-howkteam.com 10092016 -"))
            //{
            //    Console.WriteLine(item.ToString());
            //}
            #endregion
            #region Group
            //Regex re = new Regex(@"(?<hour>\d+):(?<minutes>\d+):(?<seconds>\d+)");
            ///*
            // * Duyệt qua các kết quả trùng khớp 
            // * Lấy ra giá trị của các group thông qua chỉ số phần tử là tên các group đã đặt trong biểu thức
            // */
            //foreach (Match item in re.Matches("30/04/2017 10:15:12 192.168.1.2"))
            //{
            //    Console.WriteLine(" Match:" + item.ToString());
            //    Console.WriteLine(" Hours: " + item.Groups["hours"]);
            //    Console.WriteLine(" Minutes: " + item.Groups["minutes"]);
            //    Console.WriteLine(" Seconds: " + item.Groups["seconds"]);
            //}
            #endregion
            #region Capture1
            //Regex RE = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");

            //foreach (Match item in RE.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            //{
            //    Console.WriteLine(" time: " + item.Groups["times"]);
            //    Console.WriteLine(" company: " + item.Groups["company"]);
            //    Console.WriteLine(" ip: " + item.Groups["ip"]);
            //    Console.WriteLine(" company: " + item.Groups["company"]);
            //}
            #endregion
            #region Capture 2
            Regex RE = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");
            foreach (Match item in RE.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            {
                Console.WriteLine(" time: " + item.Groups["times"]);
                Console.WriteLine(" ip: " + item.Groups["ip"]);
                Console.Write(" company: ");
                /*
                    Lấy ra tất cả các capture bắt được trong group company và duyệt lần lượt chúng
                 * Sau đó ta có thể sử dụng hàm ToString() hoặc thuộc tính Value để lấy giá trị của Capture
                 */
                foreach (Capture i in item.Groups["company"].Captures)
                {
                    Console.Write(i.ToString() + " ");
                }

            }
            #endregion
            Console.ReadLine();
        }
    }
}
