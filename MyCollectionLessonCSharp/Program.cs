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
            //Printing total and average of int array
            int[] numbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i <numbers.Length; i++)
            {
                numbers[i] = rnd.Next(50, 200);
                
            }

            foreach (var num in numbers)
            {
                Write($" |{num}");
            }
            Write("|");
            WriteLine();
            WriteLine("****************************");

            WriteLine($"Total of numbers: {numbers.Sum()}");
            WriteLine($"Average of numbers: {numbers.Average()}");

            //Second variant of printing total and average
            int sum = 0;
            double avg = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }
            WriteLine($" Total: {sum}");
            avg = (double)sum/ numbers.Length;
            WriteLine($" Average: {avg}");



            //string[] studentNames = new string[5];
            //WriteLine("Enter students name: ");
            //for(int i = 0;i < studentNames.Length;i++ )
            //{
            //    studentNames[i] = ReadLine();
            //}

            //foreach (var studentName in studentNames)
            //{
            //    Write($" |{studentName}");
            //}




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
