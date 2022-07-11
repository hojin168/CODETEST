using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11382
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strNum = Console.ReadLine().Split(' ');
            double[] Num = Array.ConvertAll(strNum, double.Parse);

            Console.WriteLine(Num[0]+ Num[1]+Num[2]);
        }
    }
}
