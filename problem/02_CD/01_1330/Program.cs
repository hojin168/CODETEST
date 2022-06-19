using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_1330
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();  // split 문법 구글링

            int A = int.Parse(ss[0]);
            int B = int.Parse(ss[1]);

            if (A > B)
            {
                Console.WriteLine(">");
            }

            else if (A < B)
            {
                Console.WriteLine("<");
            }

            else
            {
                Console.WriteLine("==");
            }

        }
    }
}

