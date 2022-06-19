using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2439
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder answer = new StringBuilder();


            int N = int.Parse(Console.ReadLine());
            


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N-i-1; j++)
                {
                    answer.Append(" ");
                    // Console.Write(" ");
                }
                for (int j = 0; j < i+1; j++)
                {
                    answer.Append("*");
                    //Console.Write("*"); 
                }

                //if (i != N - 1)
                //{
                    answer.Append("\n");
                //}
            }
            Console.WriteLine(answer.ToString());
        }
    }
}
// ctrl k c : 주석
// ctrl k u : 주석 해제