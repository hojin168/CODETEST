using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            
            string[] strInput = Console.ReadLine().Split();
            int[] arrNum = Array.ConvertAll(strInput, int.Parse);


            //string[] stri = new string[arrNum[0]];
            string[,]stri_A = new string[arrNum[0],arrNum[1]];
            string stri_tmp1;
            for (int i = 0; i < arrNum[0]; i++)
            {
                stri_tmp1 = Console.ReadLine();    // 1 2 3
                for (int j = 0; j < arrNum[1]; j++)
                {
                    stri_A[i,j] = stri_tmp1.Split(' ')[j];
                }
                //stri[i] = Console.ReadLine();
                //int[] arri = Array.ConvertAll(stri, int.Parse);
            }
          

            string[,] stri_B = new string[arrNum[0], arrNum[1]];
            string stri_tmp2;
            for (int i = 0; i < arrNum[0]; i++)
            {
                stri_tmp2 = Console.ReadLine();    // 1 2 3
                for (int j = 0; j < arrNum[1]; j++)
                {
                    stri_B[i, j] = stri_tmp2.Split(' ')[j];
                }

            }

            int[,] int_Sum = new int[arrNum[0],arrNum[1]];
      
            for (int i = 0; i < arrNum[0]; i++)
            {
                
                for (int j = 0; j < arrNum[1]; j++)
                {
                    int_Sum[i, j] = int.Parse(stri_A[i, j]) + int.Parse(stri_B[i, j]);
                    Console.Write(int_Sum[i, j]+ " ");   
                }
                Console.WriteLine();

            }

        }
    }
}
