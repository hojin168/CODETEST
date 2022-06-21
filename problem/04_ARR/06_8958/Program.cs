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

            int count = 0;


            for (int i = 0; i < caseNum; i++)
            {
                string input = Console.ReadLine();
                string [] OX = input.Split();

                for(int j = 0; j < OX.Length; j++)
                {
                    if (OX[j] == "O")
                    {
                        count += 1;
                    }
                }

            }
        }
    }
}
