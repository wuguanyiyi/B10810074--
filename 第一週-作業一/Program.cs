using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10810074_吳冠儀 {

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個數字:");
            int num1 = (Console.ReadLine()); /*將num1的值轉換為 32 位元帶正負號的整數，並讀取輸入訊息*/
            Console.WriteLine("請輸入第二個數字:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string plus = string.Format("{0}+{1}={2}",num1,num2,num1+num2);/*將num1、num2、num1+num2插入字串*/
            Console.WriteLine(plus);
            string minus = string.Format("{0}-{1}={2}", num1, num2, num1 - num2);
            Console.WriteLine(minus);
            string multiplied = string.Format("{0}*{1}={2}", num1, num2, num1 * num2);
            Console.WriteLine(multiplied);
            string divided = string.Format("{0}/{1}={2}", num1, num2, num2 / num1);
            Console.WriteLine(divided);

            Console.ReadKey();/*停止程式執行，直到按下按鍵並應用程式終止或顯示其他資訊視窗為止*/
        }
    }
}
