using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection4
{
    internal static class Task4
    {
        static int ComputeSumArray(int[] array1)
        {
            var sumArray = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"value {i} = {array1[i]}");
                sumArray = sumArray + array1[i];
            }
            return sumArray;
        }
        public static void Run()
        {
            // Task 4
            Console.WriteLine(" ");
            Console.WriteLine("Task 4. Write a C# method to compute the sum of all the elements of an array of integers.");
            Console.WriteLine(" ");
            Console.WriteLine("Input 5 integer values one by one");
            var ar1 = int.Parse(Console.ReadLine());
            var ar2 = int.Parse(Console.ReadLine());
            var ar3 = int.Parse(Console.ReadLine());
            var ar4 = int.Parse(Console.ReadLine());
            var ar5 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of array:");
            int[] array1 = { ar1, ar2, ar3, ar4, ar5};
            int result4 = ComputeSumArray(array1);
            Console.WriteLine($"is {result4}");


        }
    }
}
