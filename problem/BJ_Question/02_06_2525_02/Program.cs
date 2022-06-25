using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_06_2525_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int b = int.Parse(Console.ReadLine());
            int c = (int.Parse(a[0]) * 60) + int.Parse(a[1]) + b;
            if (c / (24 * 60) > 0)
                c %= (24 * 60);
            Console.WriteLine(c / 60 + " " + c % 60);
        }
    }
}
