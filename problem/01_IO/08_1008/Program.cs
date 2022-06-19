using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();

            decimal num1 = decimal.Parse(ss[0]);
            decimal num2 = decimal.Parse(ss[1]);

            Console.WriteLine(num1/num2);
           
        }
    }
}
