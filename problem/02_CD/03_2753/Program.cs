using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2753
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Y = int.Parse(Console.ReadLine());

            if( Y%4==0 && Y%100!=0 )
            {
                Console.WriteLine("1");
            }
            else if (Y % 400 == 0)
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
