using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_10951
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool bFlag_exit = false;
            while (!bFlag_exit)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] AB = input.Split();
                int a = int.Parse(AB[0]);
                int b = int.Parse(AB[1]);
                Console.WriteLine(a + b);

            }
        }
    }
}
