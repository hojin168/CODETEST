using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_2562
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int Nmax = 0;
            int nN = 0;
            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < 9; i++)
            {
                num = int.Parse(Console.ReadLine());

                   
                   
                    if (num > Nmax)
                    {
                        Nmax = num;
                        nN = i+1;
                    }

            }
            ans.Append(Nmax + " "+nN);
            Console.WriteLine(ans);
         
        }
    }
}



