using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一週_作業二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入身高(單位:公尺):");
           decimal height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("請輸入體重(單位:公斤):");
            int weight = Convert.ToInt32(Console.ReadLine());

            decimal bmi = weight / (height * height);/*bmi公式*/
            Console.WriteLine($"你的BMI為:{bmi:N2}");/*設定到小數第二位*/
       

            Console.ReadKey();
        }
    }
}
