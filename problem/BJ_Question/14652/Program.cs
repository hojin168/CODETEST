using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14652
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            int[] int1 = Array.ConvertAll(str1, int.Parse);

            Console.Write(int1[2] / int1[1]); Console.Write(" "); Console.Write(int1[2] % int1[1]); 

        }
    }
}
