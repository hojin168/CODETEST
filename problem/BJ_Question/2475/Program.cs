using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2475
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] s = Console.ReadLine().Split(' ');
            int[] n = Array.ConvertAll(s, int.Parse);
            int n2 = 0;
            int sum = 0;

            for (int i = 0; i < 5; i++) 
            {
                n2 = n[i] * n[i];
                sum += n2;
               

            }
            sb.Append(sum%10);
            Console.WriteLine(sb);   
        }
    }
}
