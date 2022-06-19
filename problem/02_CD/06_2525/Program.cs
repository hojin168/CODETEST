using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s2 = Console.ReadLine();


            string[] ss = s.Split();

            int H = int.Parse(ss[0]);
            int M = int.Parse(ss[1]);
            
            int C = int.Parse(s2);

            if (M + C < 60)
            {
                Console.WriteLine("{0} {1}", H, M+C);
            }

            else if (M + C >= 60 && (H + (M + C) / 60) <= 23 )
            {
                Console.WriteLine("{0} {1}", (H +(M+C)/60), ((M + C) % 60));
            }

            else if (M + C >= 60 && (H + (M + C) / 60) > 23)
            {
                Console.WriteLine("{0} {1}", ((H + (M + C) / 60)%24), ((M + C) % 60));
            }
        }
    }
}