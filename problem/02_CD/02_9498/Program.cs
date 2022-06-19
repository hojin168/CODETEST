using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_9498
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int G = int.Parse(Console.ReadLine());

            if (90 <= G && 100 >= G)
            {
                Console.WriteLine("A");
            }

            else if (80<=G && 89>=G)
            {
                Console.WriteLine("B");
            }

            else if (70 <= G && 79 >= G)
            {
                Console.WriteLine("C");
            }
            else if (60 <= G && 69 >= G)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
