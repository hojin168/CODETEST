using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01_1330
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int numA = int.Parse(str[0]);
            int numB = int.Parse(str[1]);

            if (numA > numB)
            {
                Console.WriteLine(">");

            }

            else if (numA < numB)
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

