using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_1546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
           
            float [] arrAvg = new float[N];
            float sum = 0;

            string num = Console.ReadLine();
            string[] array = num.Split(' ');
            float[] arrInt = Array.ConvertAll(array, i => float.Parse(i));

           
            float max = arrInt.Max();

            for(int i = 0; i < N; i++)
            {
                arrAvg[i] = ((arrInt[i] / max) * 100);
            }

            for (int i = 0; i < N; i++)
            {
                sum += arrAvg[i];
            }

            Console.WriteLine(sum / N);
        }
    }
}
