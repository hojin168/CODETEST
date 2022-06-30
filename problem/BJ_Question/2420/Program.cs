using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2420
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sInput = (Console.ReadLine()).Split(' ');
            long[] nInput = Array.ConvertAll(sInput, long.Parse);

            long nResult = nInput[0] - nInput[1];
            if (nResult < 0)
            {
                nResult *= -1;

                Console.WriteLine(nResult);
            }
            else
            {
                Console.WriteLine(nResult);
            }
        }
    }
}
