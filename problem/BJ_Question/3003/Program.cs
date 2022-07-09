using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrNum = Console.ReadLine().Split(' ');
            int[] arrNum_int = Array.ConvertAll(arrNum, int.Parse);
            int[] arrChess = new int[6] { 1, 1, 2, 2, 2, 8 };
            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0} ", arrChess[i] - arrNum_int[i]);
            }
            Console.WriteLine();
        }
    }
}
