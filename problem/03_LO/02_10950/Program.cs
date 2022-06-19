using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_10950
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int t = int.Parse(Console.ReadLine());
           
            
            for (int i = 1; i <= t; i++)
            {
                string sz1 = Console.ReadLine();
                string[] sz2 = sz1.Split();

                int n1 = int.Parse(sz2[0]);
                int n2 = int.Parse(sz2[1]);
                Console.WriteLine(n1+n2);
            }
        }
    }
}
