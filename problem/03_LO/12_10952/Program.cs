using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10952
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            bool bFlag_exit = false;
            while (!bFlag_exit) //true         // !t = f
            {
                string[] s = Console.ReadLine().Split();
                StringBuilder sb = new StringBuilder();
                int num1 = int.Parse(s[0]);
                int num2 = int.Parse(s[1]);

                if (num1 == 0 && num2 == 0)     // 00..
                {
                    bFlag_exit = true;

                }
                else
                {
                    sb.Append(num1 + num2);
                    Console.WriteLine(sb.ToString());
                }
              
            }

            // appen...


        }
    }
}
