using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
          


            string[] s = Console.ReadLine().Split();
            int nNum_Case = int.Parse(s[0]);
            int nNum_Comp = int.Parse(s[1]);

            string[] s2 = Console.ReadLine().Split();
            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < nNum_Case; i++)
            {
                if (int.Parse(s2[i]) < nNum_Comp) ans.Append(s2[i] + " ");
            }

            Console.WriteLine(ans.ToString());
        }
    }

}