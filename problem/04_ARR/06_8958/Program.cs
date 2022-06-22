using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_8958
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int caseNum = int.Parse(Console.ReadLine());

            
            string input;
            string[] OX;
            int num = 0;
            int sum = 0;

            for (int i = 0; i < caseNum; i++)
            {
                input = Console.ReadLine();
                OX = input.Split('X');
                sum = 0;
                for (int j = 0; j < OX.Length; j++)
                {
                    num = (OX[j].Length)*(OX[j].Length+1)/2;
                    sum += num;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
