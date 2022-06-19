using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//시간 초과 
namespace _05_2741
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder sb = new StringBuilder();

            int num = int.Parse(Console.ReadLine());
              
       

            for (int i = 1; i <= num; i++)
            {
                sb.AppendLine(i.ToString());
              
            }
            Console.WriteLine(sb);


        }
    }
}