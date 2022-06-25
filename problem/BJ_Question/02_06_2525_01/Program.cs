using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_06_2525_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTime = Console.ReadLine();
            string inputNeedingTime = Console.ReadLine();

            string[] inputArrayTime = inputTime.Split();

            int hour = int.Parse(inputArrayTime[0]);
            int minute = int.Parse(inputArrayTime[1]);
            int needingTime = int.Parse(inputNeedingTime);

            int resultMinute = hour * 60 + minute + needingTime;

            Console.WriteLine((resultMinute % 1440) / 60 + " " + resultMinute % 60);
        }
    }
}
