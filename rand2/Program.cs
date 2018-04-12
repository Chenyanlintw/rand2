using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 將所有號碼都放入 List 之中
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }

            // 產生亂數物件
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                // 2. 隨機挑選"剩下的"其中一個印出
                int r = rand.Next(1, numbers.Count);
                Console.Write(numbers[r]+" ");

                // 3. 並從 List 中刪除
                numbers.RemoveAt(r);
            }

            Console.ReadKey();
        }
    }
}
