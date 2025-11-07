using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            int oddCount = 0;
            Console.WriteLine("plese enter 10 numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"number{i}:");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    ++evenCount;
                else
                    ++oddCount;
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"number of even numbers:{evenCount}");
                    Console.WriteLine($"number of odd numbers:{oddCount}");

                }

            }


        }
    }
}
