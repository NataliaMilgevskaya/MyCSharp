using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection3
{
    internal static class Task1

    {
        public static void Run()
        {

            // Task 1

            Console.WriteLine("Task 1. Write a C# program to check two given integers and return true if one is negative and one is positive.");
            Console.WriteLine(" ");

            Console.WriteLine("Input first integer:");
            int l3a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");
            int l3b = int.Parse(Console.ReadLine());

            if ((l3a > 0 || l3b > 0) && (l3a < 0 || l3b < 0))
            {
                Console.WriteLine($"Selected values: {l3a} and {l3b}. One of variables is positive, one is negative, so return - TRUE");
            }
            else
            {
                Console.WriteLine($"Selected values: {l3a} and {l3b}. One is negative and one is positive is not correct for selected values, so return - FALSE");
            }
            Console.WriteLine(" ");
        }
    }
}
