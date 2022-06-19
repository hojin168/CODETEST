using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2480
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string ==> sz
            // int, double, float ==> n
            // bool    ==> b
            string sz1 = Console.ReadLine();
    

            string[] sz2 = sz1.Split();

            int nDice1 = int.Parse(sz2[0]);
            int nDice2 = int.Parse(sz2[1]);
            int nDice3 = int.Parse(sz2[2]);

            if(nDice1 == nDice2 && nDice2 == nDice3)
            {
                Console.WriteLine(10000 + (nDice1 * 1000));
            }

            else if (nDice1 == nDice2 && nDice2 != nDice3)
            {
                Console.WriteLine(1000 + (nDice1 * 100));
            }

            else if (nDice2 == nDice3 && nDice1 != nDice3)
            {
                Console.WriteLine(1000 + (nDice2 * 100));
            }

            else if (nDice1 == nDice3 && nDice2 != nDice3)
            {
                Console.WriteLine(1000 + (nDice1 * 100));
            }

            else if (nDice1 != nDice3 && nDice2 != nDice3 && nDice1 !=nDice2)
            {
                if (nDice1 < nDice2 && nDice2 < nDice3)
                {
                    Console.WriteLine(nDice3 * 100);
                }

                else if (nDice2 < nDice1 && nDice1 < nDice3)
                {
                    Console.WriteLine(nDice3 * 100);
                }

                else if (nDice3 < nDice2 && nDice2 < nDice1)
                {
                    Console.WriteLine(nDice1 * 100);
                }

                else if (nDice2 < nDice3 && nDice3 < nDice1)
                {
                    Console.WriteLine(nDice1 * 100);
                }

                else if (nDice3 < nDice1 && nDice1 < nDice2)
                {
                    Console.WriteLine(nDice2 * 100);
                }

                else if (nDice1 < nDice3 && nDice3 < nDice2)
                {
                    Console.WriteLine(nDice2 * 100);
                }
            }
        }
    }
}
