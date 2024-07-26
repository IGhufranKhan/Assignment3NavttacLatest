using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Reflection;

namespace Assignment3Navttac
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* Lecture 6 
              * Arrays
              * Dictionery
              * Method
              debugger ko ham wapis uper bhi lekr ja skty hain.
              jab chalti application ma change krni ho or program na band krna chahty hon to hot reload use krain gy
              Methods of list
              List of T a list with any dataType
              List<T> Where T is Generic
              after using methods hover that to check the return type of it
              Assignment is exploring the methods with Go to defination
              Capacity or Count dekh k ana ha count k method ki properties ma
              array sir by default data type pa banti ha or list hamari custom data types pa bhi ban skti ha
              array fix size ki hoti ha is ma hamna size define krna hot ha. Or list hmari dynamic hoti ha usma add or remove bhi kr skty hain
              */

            //Using nested for loops print these patterns
            int sum = Sum("2", 3);
            Console.WriteLine($"Sum = {sum}");
            int Sum(string a, int b)
            {
                int aInt = Convert.ToInt32(a);

                int sum = aInt + b;
                return sum;
            }
            //List<int> marks = new List<int>
            //{
            //    19,
            //    25,
            //    18,
            //    34,
            //    23
            //};
            //int count = marks.Count;
            //List<string> stringList = new List<string>();
            //stringList.Add("1");
            //stringList.AddRange();
            //stringList.ForEach();
            //stringList.BinarySearch();
            //stringList.Contains();



            // Arrays
            // syntax



            List<int> num = new List<int>
            {
                5,6,7,8
            };
            List<int> num1 = new List<int>
            {
                1,2,3,4
            };
            for (int i = 0; i < 4; i++)
            {
                num.Add(i);
                if (i <= 3)
                {
                    if (i == 0)
                    {
                        num1.Clear();
                        num1.Add(num[i]);
                    }
                    else
                    {
                        num1.Add(num[i]);
                    }


                }
                else
                    if (i == 4)
                {

                }
                

            }
            num.RemoveRange(4, 4);


            // do list int or string dono ka data shuffle krna ha
            Console.ReadKey();
        }
    }
}
