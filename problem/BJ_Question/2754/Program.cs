using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2754
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string score = Console.ReadLine();

            string a1 = "A+";
            string a2 = "A0";
            string a3 = "A-";
            string b1 = "B+";
            string b2 = "B0";
            string b3 = "B-";
            string c1 = "C+";
            string c2 = "C0";
            string c3 = "C-";
            string d1 = "D+";
            string d2 = "D0";
            string d3 = "D-";
            string f = "F";

            if (score.Equals(a1))
            {
                Console.WriteLine("4.3");
            }

            if (score.Equals(a2))
            {
                Console.WriteLine("4.0");
            }

            if (score.Equals(a3))
            {
                Console.WriteLine("3.7");
            }

            if (score.Equals(b1))
            {
                Console.WriteLine("3.3");
            }

            if (score.Equals(b2))
            {
                Console.WriteLine("3.0");
            }

            if (score.Equals(b3))
            {
                Console.WriteLine("2.7");
            }

            if (score.Equals(c1))
            {
                Console.WriteLine("2.3");
            }

            if (score.Equals(c2))
            {
                Console.WriteLine("2.0");
            }

            if (score.Equals(c3))
            {
                Console.WriteLine("1.7");
            }

            if (score.Equals(d1))
            {
                Console.WriteLine("1.3");
            }

            if (score.Equals(d2))
            {
                Console.WriteLine("1.0");
            }

            if (score.Equals(d3))
            {
                Console.WriteLine("0.7");
            }

            if (score.Equals(f))
            {
                Console.WriteLine("0.0");
            }
        }
    }
}
