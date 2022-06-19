using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2588
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int a = int.Parse(num1);
            int b = int.Parse(num2);

            int a1 = (a % 10);
            int b1 = (b % 10);
            int b2 = (((b % 100)-(b % 10))/10);
            int b3 = (b / 100);
            Console.WriteLine(b1*a);
            Console.WriteLine(b2*a);
            Console.WriteLine(b3*a);
            Console.WriteLine((b1*a)+(b2*a*10)+ (b3 * a * 100));


        }
    }
}
