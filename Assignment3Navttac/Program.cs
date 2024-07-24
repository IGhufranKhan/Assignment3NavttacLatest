using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Assignment3Navttac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using nested for loops print these patterns
            Console.WriteLine("Using nested for loops print these patterns \n");
            Console.WriteLine("\nSolution 1:");
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nSolution 2: \n");
            for (int i = 3; i >= 1; i--)
            {
                if (i == 2)
                {
                    i++;
                    for (int j = i; j >= 2; j--)
                    {
                        Console.Write(j);
                    }
                    i--;
                }
                else
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                }

                Console.WriteLine();
            }
            //Store these marks in a list and display average of student, max marks, minumum
            Console.WriteLine("\nSolution for Store marks in a list and display average of student, max marks, minumum marks \n\n");
            List<int> marks = new List<int> { 0, 98, 67, 9, 45, 44, 23, 2 };
            int averageMarks = 0;
            int maxMarks = 0;
            int minMarks = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                averageMarks += marks[i];
                if (marks[i] > maxMarks)
                {
                    maxMarks = marks[i];
                }
                if (marks[i] < minMarks)
                {
                    minMarks = marks[i];
                }
            }
            averageMarks = averageMarks / marks.Count;
            Console.WriteLine($"Average marks of Student is: {averageMarks}");
            Console.WriteLine($"Max marks of Student is: {maxMarks}");
            Console.WriteLine($"Min marks of Student is: {minMarks}");
            Console.ReadKey();
        }
    }
}
