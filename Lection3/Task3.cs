using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection3
{
    internal static class Task3
    {
        public static void Run()
        {
            // Task 3
            Console.WriteLine("Task 3. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.");
            Console.WriteLine(" ");

            Console.WriteLine("The list of odd numbers from 1 to 99:");
            int l3f = 1;
            int l3fResult;

            while (l3f < 99)
            {
                l3fResult = l3f % 2;
                if (l3fResult == 0)
                {
                    Console.WriteLine($"Value {l3f}");
                }
                l3f++;
            }
            Console.WriteLine(" ");
        }
    }
}
