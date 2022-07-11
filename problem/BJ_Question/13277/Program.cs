using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13277
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strNum = Console.ReadLine().Split(' ');
            double[] Num = Array.ConvertAll(strNum, double.Parse);
        }
    }
}
