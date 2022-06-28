using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1271
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s =  (Console.ReadLine()).Split(' ');
            int[] ss = Array.ConvertAll(s, int.Parse);

            Console.WriteLine(ss[0] / ss[1]);
            Console.WriteLine(ss[0] % ss[1]);
        }
    }
}
