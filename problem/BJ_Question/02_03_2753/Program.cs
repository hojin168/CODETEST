using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_2753
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int years = int.Parse(s);

            if (years % 4 == 0 && years % 100 != 0 || years % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
