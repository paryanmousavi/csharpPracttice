using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("enter saide a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("enter saide b :");
            b = double.Parse(Console.ReadLine());
            Console.Write("enter saide c :");
            c = double.Parse(Console.ReadLine());
            double perimeter = a + b + c;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("perimeter:" + perimeter);
            Console.WriteLine("Area:" + area);



            {
                
            }



        }
    }
}
