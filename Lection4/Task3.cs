using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyCSharpProject.Lection4
{
    internal static class Task3
    {
        static int NearestTo20( int num13,  int num23)
        {
            var tempa = 20 - num13;
            var tempb = 20 - num23;
            var result3 = 0;
            if (tempa < 0)
            {
                tempa *= -1; 
            }

            if (tempb < 0)
            {
                tempb *= -1;
            }
            Console.WriteLine($"num13 = {num13}, num23 = {num23}, tempa = {tempa}, tempb = {tempb}");

            if (tempa == tempb)
            {
                result3 = 0;
            }
            else
                {
                    if (tempa > tempb)
                    {
                        result3 = num23;
                    }
                    else
                    {
                        result3 = num13;
                    }
                }


            return result3;
        }
        public static void Run()
        {
            // Task 3
            Console.WriteLine(" ");
            Console.WriteLine("Task 3. Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same.");
            Console.WriteLine(" ");

            Console.WriteLine("Input two integer value one by one");
            var num13 = int.Parse(Console.ReadLine());
            var num23 = int.Parse(Console.ReadLine());
            var result3 = NearestTo20( num13,  num23);
            if (num13 == num23)
            {
                Console.WriteLine($"The value {num13} and {num23} are the same, so result {result3}");
            }
            else
            {
                Console.WriteLine($"The nearest value of 20 of two integers {num13} and {num23} is {result3}");
            }

        }
    }
}
