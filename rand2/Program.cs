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
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(rand.Next(1, 43));
            }

            Console.ReadKey();
        }
    }
}
