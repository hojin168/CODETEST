using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_10998
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s= Console.ReadLine();
            string[]ss= s.Split();

            int num1 = int.Parse(ss[0]);
            int num2 = int.Parse(ss[1]);
            
            Console.WriteLine(num1*num2);
        }
    }
}
