using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            int N2 = N;
            int a = 0;

            bool bFlag_exit = false;
            while (!bFlag_exit)
            {
                if (N2 < 10)
                {
                    N2 = N2 * 10 + N2;
                    a++;
                }
                else
                {
                    N2 = (N2 % 10) * 10 + (((N2 / 10) + N2 % 10) % 10);
                    a++;
                }

                if (N == N2)
                {
                    Console.WriteLine(a);
                    bFlag_exit = true;
                }
            }
        }
    }
}
