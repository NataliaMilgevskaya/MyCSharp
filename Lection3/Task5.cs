using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection3
{
    internal static class Task5
    {
        public static void Run()
        {
            // Task 5
            Console.WriteLine("Task 5. Write a C# program and compute the sum of the digits of an integer.");
            Console.WriteLine(" ");

            Console.WriteLine("Input any intenger:");
            string number = Console.ReadLine();
            int count = number.Length;
            int sum2 = 0;

            for (int x = 0; x < count; x++)
            {
                sum2 = sum2 + Convert.ToInt32(new string(number[x], 1));
            }


            Console.WriteLine($"You input {number}. We count characters {count} and sum {sum2} ");
            Console.WriteLine(" ");
        }
    }
}
