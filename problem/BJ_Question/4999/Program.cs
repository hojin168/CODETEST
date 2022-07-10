using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int n1 = str1.Length;
            int n2 = str2.Length;

            if (n1 < n2)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("go");
            }

        }
    }
}
