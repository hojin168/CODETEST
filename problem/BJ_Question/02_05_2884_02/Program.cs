using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2884_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] time = Console.ReadLine().Split(' ');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);

            if (hour == 0 && minute < 45)
            {
                Console.WriteLine(23 + " " + (minute + 15));
            }
            else
            {
                var sum = hour * 60 + minute - 45;
                Console.WriteLine(sum / 60 + " " + sum % 60);
            }
        }
    }
}
