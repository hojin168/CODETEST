﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10872
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int result = 1;
            for(int i = 0; i < N; i++)
            {
                result *= (N - i);
            }

            Console.WriteLine(result);
        }
    }
}
