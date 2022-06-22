using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace _07_4344
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int caseNum = int.Parse(Console.ReadLine());
            

            for (int j = 0; j < caseNum; j++)
            {
                float count = 0;
                string num = Console.ReadLine();
                string[] array = num.Split(' ');

                int[] arrInt = Array.ConvertAll(array, i => int.Parse(i));

                int L = arrInt.Length;
                float sum = 0;

                for (int i = 1; i < L; i++)
                {
                    sum += arrInt[i];
                   
                }
                float avg = sum / (L - 1);
                for (int i = 1; i < L; i++)
                {
                    if (avg < arrInt[i])
                    {
                        count++;    
                    }
                
                }
                float result = ((count / (L - 1)) * 100);
                double result2 = Math.Round(result, 3);
                string result3 = result2.ToString();
                string str = string.Format("{0:0.000}", double.Parse(result3));
                Console.WriteLine(str + "%");

            }

        }
    }
}
