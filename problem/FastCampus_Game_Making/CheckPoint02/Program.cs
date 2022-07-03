using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint02
{
    internal class Program
    {
        const string LINE = "--------------------------------------------";
        const int END_LINE = 42;
        const int DELAY_TIME = 200;
        static int runA = 0;
        static int runB = 0;
        static int runC = 0;
        static int runD = 0;



        static void ClearScreen()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void Process(ref Random rnd)
        {
            ++runA;
            ++runB;
            ++runC;
            ++runD;

            int rndNum = rnd.Next(0, 4);
            int runRndNum = rnd.Next(0, 2);
            switch (rndNum)
            {
                case 0:
                    runA += runRndNum;
                    break;
                case 1:
                    runB += runRndNum;
                    break;
                case 2:
                    runC += runRndNum;
                    break;
                case 3:
                    runD += runRndNum;
                    break;
            }
        }


        static void UpdateScreen()
        {
            int numS1 = 0;
            int numS2 = 0;
            int numS3 = 0;
            int numS4 = 0;
            string strS1;
            string strS2;
            string strS3;
            string strS4;

            for (int i = 0; i < runA; i++)
            {
                Console.Write(" ");
                numS1 += runA;
            }
            strS1 = "|".PadLeft((END_LINE + 1) - runA);
            Console.WriteLine("1" + strS1);


            for (int i = 0; i < runB; i++)
            {
                Console.Write(" ");
                numS2 += runB;
            }
            strS2 = "|".PadLeft((END_LINE + 1) - runB);
            Console.WriteLine("2" + strS2);

            for (int i = 0; i < runC; i++)
            {
                Console.Write(" ");
                numS3 += runC;
            }
            strS3 = "|".PadLeft((END_LINE + 1) - runC);
            Console.WriteLine("3" + strS3);

            for (int i = 0; i < runD; i++)
            {
                Console.Write(" ");
                numS4 += runD;
            }
            strS4 = "|".PadLeft((END_LINE + 1) - runD);
            Console.WriteLine("4" + strS4);

            Console.WriteLine(LINE);
            if (runA >= runB && runA >= runC && runA >= runD)
            {
                Console.WriteLine("선두주자:1 " + "선두주자 위치: " + runA);
            }

            else if (runB >= runA && runB >= runC && runB >= runD)
            {
                Console.WriteLine("선두주자:2 " + "선두주자 위치: " + runB);
            }

            else if (runC >= runA && runC >= runB && runC >= runD)
            {
                Console.WriteLine("선두주자:3 " + "선두주자 위치: " + runC);
            }

            else
            {
                Console.WriteLine("선두주자:4 " + "선두주자 위치: " + runD);
            }
        }



        static bool CheckResult()
        {
            if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
            {
                string strResult = "결과: !!{0} 선수 우승!!";
                int runNum = 0;

                if (runA >= END_LINE)
                    runNum = 1;
                else if (runB >= END_LINE)
                    runNum = 2;
                else if (runC >= END_LINE)
                    runNum = 3;
                else
                    runNum = 4;
                Console.WriteLine(strResult, runNum);

                Console.Write("다시하시려면 0번 입력:  ");
                if (int.Parse(Console.ReadLine()) == 0)
                {
                    runA = 0;
                    runB = 0;
                    runC = 0;
                    runD = 0;

                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;  // 조건이 아닐경우 true
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();



            while (true)
            {
                ClearScreen();

                Process(ref rnd);

                Console.WriteLine(LINE);

                UpdateScreen();


                if (CheckResult() == false)
                    break;

            }
        }
    }
}



