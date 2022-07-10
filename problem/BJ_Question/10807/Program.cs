using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());
            string str1 = Console.ReadLine();
            int numv = int.Parse(Console.ReadLine());

            int count = 0;

            string[] arr1 = str1.Split(' ');
            int[] arrInt = Array.ConvertAll(arr1, int.Parse);

            for(int i = 0; i < numN; i++)
            {
                if (arrInt[i] == numv)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
