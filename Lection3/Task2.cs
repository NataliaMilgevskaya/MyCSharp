using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection3
{
    internal static class Task2
    {
        public static void Run()
        {

            // Task 2
            Console.WriteLine("Task 2. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.");
            Console.WriteLine(" ");

            Console.WriteLine("Input two integers one by one");
            var l3c = int.Parse(Console.ReadLine());
            var l3d = int.Parse(Console.ReadLine());
            int l3e = l3c + l3d;

            if (l3c == 20 || l3d == 20 || l3e == 20)
            {
                Console.WriteLine($"Your input two integers {l3c} and {l3d}. The app checked rule: The sum of the two given integers and return true if one of the integer is 20 or if their sum is 20, and returns TRUE");
            }
            else
            {
                Console.WriteLine($"Your input two integers {l3c} and {l3d}. The app checked rule: The sum of the two given integers and return true if one of the integer is 20 or if their sum is 20, and returns FALSE");
            }
            Console.WriteLine(" ");

        }
    }
}
