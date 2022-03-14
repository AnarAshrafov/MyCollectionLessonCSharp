using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace MyCollectionLessonCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[5];
            WriteLine("Enter students name: ");
            for(int i = 0;i < studentNames.Length;i++ )
            {
                studentNames[i] = ReadLine();
            }

            foreach (var studentName in studentNames)
            {
                Write($" |{studentName}");
            }




            //int[] numArr = new int[6];
            //numArr[0] = 10;
            ////numArr[2] = 20;
            //numArr[1] = 30;
            //numArr[3] = 40;
            //numArr[4] = 50;
            //numArr[5] = 60;
            //Array.Resize(ref numArr,10);

            //WriteLine();
            //foreach (var num in numArr)
            //{
            //    Write($" | {numArr[num]}");
            //}

            //for (int i = 0;i < numArr.Length;i++)
            //{
            //    Write($" | {numArr[i]}");
            //}

            //Write(" |\n");

            ReadKey();
        }
       
    }
}
