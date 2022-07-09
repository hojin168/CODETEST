using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char sTest = 'a';
            //int a = (int)sTest ;

            string strInput = Console.ReadLine();
            {
                int i;
                int[] arrASC = new int[strInput.Length];
                for ( i = 0; i < strInput.Length; i++)
                {
                  //  char a = strInput[i];
                    char a = Convert.ToChar(strInput[i]);
                    arrASC[i]  = Convert.ToInt32(a);
                    if (arrASC[i] <= 90)
                    {
                        arrASC[i] += 32;
                    
                        char c = Convert.ToChar(arrASC[i]);
                        Console.Write(c);
                         
                    }
                    else
                    {
                        arrASC[i] -= 32;
                        char c = Convert.ToChar(arrASC[i]);
                        Console.Write(c);
                    }

                }
             
            }
       
        }
    }
}
// 시간단축
//using System;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string inputString = Console.ReadLine();
//            string changeString = "";

//            for (int i = 0; i < inputString.Length; i++)
//            {
//                if (inputString[i] <= 90)
//                {
//                    changeString += (char)(inputString[i] + 32) + "";
//                }
//                else
//                {
//                    changeString += (char)(inputString[i] - 32) + "";
//                }
//            }

//            Console.WriteLine(changeString);
//        }
//    }
//}