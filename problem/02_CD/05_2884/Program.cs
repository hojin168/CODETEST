using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2884
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(); 

            int H = int.Parse(ss[0]);
            int M = int.Parse(ss[1]);

            if (M >= 45)
            {
                Console.WriteLine("{0} {1}", H, M - 45);
            }

            else if (H >= 1 && M < 45)
            {
                Console.WriteLine("{0} {1}", H - 1, M + 15);
            }

            else if (H == 0 && M < 45)
            {
                Console.WriteLine("{0} {1}", 23, M + 15);
            }
        }
    }
}
