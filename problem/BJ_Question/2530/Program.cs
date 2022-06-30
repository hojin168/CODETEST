using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] sInput = Console.ReadLine().Split(' ');
            int[] nInput = Array.ConvertAll(sInput, int.Parse);

            int nH = 0, nM = 0, nS = 0;
            int nInput2 = int.Parse(Console.ReadLine());
            int nSec = nInput[0] * 3600 + nInput[1] * 60 + nInput[2] + nInput2;

            int nResultSec = nSec % (3600 * 24);

            nH = nResultSec / 3600;
            nM = (nResultSec % 3600)/60;
            nS = (nResultSec % 3600)%60;

            string sTime;

            sTime = nH.ToString() + ' ' + nM.ToString() + ' ' + nS.ToString();

            sb.Append(sTime);

            Console.WriteLine(sb);
        }
    }
}
