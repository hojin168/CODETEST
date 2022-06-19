using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_2739
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i<=9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
            }

        }
    }
}
