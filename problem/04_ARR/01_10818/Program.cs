using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_10818
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nCase = int.Parse(Console.ReadLine());
            int[] num = new int[nCase];

            string[] s = Console.ReadLine().Split(' ');

            StringBuilder ans = new StringBuilder();

            int Nmin = 1000000;
            int Nmax = -1000000;

            for (int i = 0; i < s.Length; i++)
            {
                
                int numS = int.Parse(s[i]);
           
                if (numS < Nmin)
                {
                    Nmin = numS;
                } 
                
                if (numS> Nmax)
                {                    
                    Nmax = numS;
                }
            }
            ans.Append(Nmin + " " + Nmax);
            Console.WriteLine(ans);
        }
    }
}
