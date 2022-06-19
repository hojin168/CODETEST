using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_14681
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int x = int.Parse(s1);
        int y = int.Parse(s2);
            
            if (x>0 && y>0)
            {
                Console.WriteLine("1");
            }
            else if (x<0 && y>0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
        }
    }
}
