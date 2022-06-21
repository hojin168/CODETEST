using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_3052
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            int[] array = new int[10];
            int[] array2= new int[10];


            for (int i = 0; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                array2[i] = (array[i] % 42);
            }
            int[] array3 = array2.Distinct().ToArray();  // 중복 값 제거 배열 생성

            Console.WriteLine("{0}", array3.Length);
        }
    }
}
