using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2742
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            int num = int.Parse(Console.ReadLine());




            for (int i = num; i >= 1; i--)
            {
                sb.Append(i);

                sb.Append("\n");
            }
            Console.WriteLine(sb);


        }
    }
}