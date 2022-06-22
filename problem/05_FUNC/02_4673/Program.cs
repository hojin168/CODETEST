using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_4673
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int result = 0;


            bool[] bExit = new bool[10000]; 
            //while (!bflag_exit)


            for (i = 0 ; i < 10000 ; i++)
            {
                result = SUM_diget(i+1);
                if (result-1 < 10000)
                {
                    bExit[result-1] = true;
                }
               
            }

            // 100 101 102 103 ㅣ.,ㅣㅣ110


            for(i = 0 ; i < 10000; i++)
            {
                if (bExit[i] == false)
                {
                    Console.WriteLine(i + 1);
                }
            }
            
        }

        static int SUM_diget(int num)
        {
            int sum = 0;
            int result = 0;
            int nSelf = num;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            result = sum + nSelf;

            return result;
        }
    }
}
