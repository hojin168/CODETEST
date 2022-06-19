using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_15552
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  스트링빌터 ans 선언
            StringBuilder ans = new StringBuilder(); 

            int num= int.Parse(Console.ReadLine());
            // 배열 생성
            int[] a = new int[num];
            int[] b = new int[num];

            for (int i = 0; i < num; i++)
            {
                // 문자열 배열 선언
                string[] s = Console.ReadLine().Split();
                // 입력받은 문자를 int 변환 
                a[i] = int.Parse(s[0]);
                b[i] = int.Parse(s[1]);

                // 각 숫자를 더한 뒤 문자열로 변환, ans에 대입
                ans.AppendLine((a[i] + b[i]).ToString());
            }   
            Console.WriteLine(ans.ToString());
        }
    }
}