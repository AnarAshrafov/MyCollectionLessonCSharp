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
            //Sorting of randomly created arrays by pattern
            Random rnd = new Random();
            int arraySize = rnd.Next(100,200);
            
            int[] numbers = new int[arraySize];

            int[] newNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0,99);
            }

            int front = 0, rear = newNumbers.Length - 1;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    newNumbers[front] = item;
                    front++;
                }
                else
                {
                    newNumbers[rear] = item;
                    rear--;
                }
            }

            foreach (var num in numbers)
            {
                Write($" | {numbers[num]}");
            }

            
            WriteLine("\n**************************\n");
            WriteLine("\n**************************\n");
            WriteLine("\n**************************\n");
            foreach (var num in newNumbers)
            {
                Write($" | {newNumbers[num]}");
            }



            ////Printing total and average of int array
            //int[] numbers = new int[10];
            //Random rnd = new Random();

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    numbers[i] = rnd.Next(50, 200);

            //}

            //foreach (var num in numbers)
            //{
            //    Write($" |{num}");
            //}
            //Write("|");
            //WriteLine();
            //WriteLine("****************************");

            //WriteLine($"Total of numbers: {numbers.Sum()}");
            //WriteLine($"Average of numbers: {numbers.Average()}");

            ////Second variant of printing total and average
            //int sum = 0;
            //double avg = 0;

            //foreach (var num in numbers)
            //{
            //    sum += num;
            //}
            //WriteLine($" Total: {sum}");
            //avg = (double)sum/ numbers.Length;
            //WriteLine($" Average: {avg}");



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
