using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection4
{
    internal static class Task5
    {
        static int FindMaxValue(int[] arr)
        {
            int resultMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr {i} = {arr[i]}");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > resultMax)
                {
                    resultMax = arr[i];

                }
            }
            return resultMax;
        }
        public static void Run()
        {
            // Task 5
            Console.WriteLine(" ");
            Console.WriteLine("Task 5. Write a C# method to get the larger value from array.");
            Console.WriteLine(" ");
            Console.WriteLine("Input 5 integer values one by one");
            var ar1 = int.Parse(Console.ReadLine());
            var ar2 = int.Parse(Console.ReadLine());
            var ar3 = int.Parse(Console.ReadLine());
            var ar4 = int.Parse(Console.ReadLine());
            var ar5 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The the larger value from array:");
            int[] arr = { ar1, ar2, ar3, ar4, ar5 };
            int result5= FindMaxValue(arr);

            Console.WriteLine($"is {result5}");
            ;
        }
    }
}
