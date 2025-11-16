using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace example2_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Multiplay(int a, int b)
            {
                if (b == 0)
                    return 0;
                return a + Multiplay(a, b - 1);
                {
                    
                        {
                        Console.Write(" enter the ferst number :");
                        int.Parse(Console.ReadLine ());
                        int numb1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the second number:");
                        int num2 = int.Parse(Console.ReadLine());
                        int result = Multiplay(numb1, num2);
                        Console.WriteLine("the result of multiplication is :+ result");
                    }
                }
            }

        }

    }
}
    
