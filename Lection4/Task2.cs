using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection4
{
    internal static class Task2
    {
        static int MinThreeNumbers(int num11, int num21, int num31)
        {
            int result1 = 0;


            if (num11 <= num21)
            {
                if (num11 <= num31)
                {
                    result1 = num11;
                }
                else
                {
                    if (num31 <= num21)
                    {
                        result1 = num31;
                    }
                }
            }
            else
            {
                result1 = num21;
            }


            return result1;
        }
        public static void Run()
        {

            // Task 2
            Console.WriteLine(" ");
            Console.WriteLine("Task 2. Write a C# method to find the lowest value from three integer values.");
            Console.WriteLine(" ");

            Console.WriteLine("Input three integer value one by one");
            var num11 = int.Parse(Console.ReadLine());
            var num21 = int.Parse(Console.ReadLine());
            var num31 = int.Parse(Console.ReadLine());
            var result1 = MinThreeNumbers(num11, num21, num31);
            Console.WriteLine($"The lowest value of {num11}, {num21}, {num31} is {result1}");

        }
    }
}
