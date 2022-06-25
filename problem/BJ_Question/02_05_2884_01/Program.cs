using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2884_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();

            int H = int.Parse(ss[0]);
            int M = int.Parse(ss[1]);
            if (H < 0 || H > 24 || M < 0 || M > 59) return;

            if (M < 45)
            {
                H--;
                M += 15;
                if (H < 0)
                {
                    H = 23;
                }
            }
            else
            {
                M -= 45;
            }
            Console.WriteLine("{0} {1}", H, M);
        }
    }
}
