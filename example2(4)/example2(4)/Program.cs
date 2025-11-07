using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {int position = -1;
            Console.WriteLine("plese enter 5 numbers:");
            for(int i = 1; i<=5; i++)
            {
                Console.Write($"number{i}:");
                int number = int.Parse(Console.ReadLine());
                if (number == 2)
                {
                    position = i;
                    break;
                }
            }
            }
    }
}
