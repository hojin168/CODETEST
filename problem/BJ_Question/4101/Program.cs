using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrNum;
            int[] arrNum_int;
     

            while (true) 
            {
                arrNum = Console.ReadLine().Split(' ');
                arrNum_int = Array.ConvertAll(arrNum, int.Parse);

                if (arrNum_int[0] == 0 && arrNum_int[1] == 0)
                { break; }
                if (arrNum_int[0] > arrNum_int[1])
                {
                    Console.WriteLine("Yes");
                }
       
                else
                {
                    Console.WriteLine("No");
                }
            }
 
        }
    }
}
