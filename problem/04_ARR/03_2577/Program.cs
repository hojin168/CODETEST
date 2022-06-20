using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2577
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int[] Count = new int[] {0,0,0,0,0,0,0,0,0,0};
            int n0i = 0;
         
            String num =  (A * B * C).ToString();

            for (int i = 0; i < num.Length; i++)
            {

                string n0 = num.Substring(i, 1);
                n0i = int.Parse(n0);

                {
                   for (int j = 0; j < 10; j++)
                   {
                        if (j == n0i)   // 1
                        {
                            Count[j]++;
                        }
                        
                    }
                   
                }
                
            }
            for (int i = 0; i < 10; i++)
            {
                  Console.WriteLine(Count[i]);

            }
        }
    }
}
