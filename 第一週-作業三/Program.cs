using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一週_作業三
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入攝氏溫度:");
            int celsius =Convert.ToInt32(Console.ReadLine());
            string Fahrenheit = string.Format("{0}",celsius*9/5+32);/*將攝氏轉華氏公式插入字串*/
            string tabsolute = string.Format("{0}",celsius+273.15);/*將攝氏轉絕對溫度公式插入字串*/

            Console.WriteLine($"{celsius}°C = {Fahrenheit}°F = {tabsolute}K");


            Console.ReadKey();
        }
    }
}
