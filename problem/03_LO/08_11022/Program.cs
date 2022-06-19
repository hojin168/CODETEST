using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_11022
{
    internal class Program
    {
        static void Main(string[] args)
        {


            StringBuilder ans = new StringBuilder();

            int num = int.Parse(Console.ReadLine());

            int[] a = new int[num];
            int[] b = new int[num];

            for (int i = 0; i < num; i++)
            {

                string[] s = Console.ReadLine().Split();

                a[i] = int.Parse(s[0]);
                b[i] = int.Parse(s[1]);


                Console.WriteLine("Case #{0}: {1} + {2} = {3}", i + 1, a[i], b[i], a[i] + b[i]);


            }

        }
    }
}