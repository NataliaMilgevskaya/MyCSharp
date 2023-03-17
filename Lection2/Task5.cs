using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection2
{
    internal static class Task5
    {
        public static void Run()
        {
            // Task 5
            Console.WriteLine("Task 5. Print the output of multiplication of three numbers which will be entered by the user");

            var varUserInput1 = int.Parse(Console.ReadLine());
            var varUserInput2 = int.Parse(Console.ReadLine());
            var varUserInput3 = int.Parse(Console.ReadLine());

            int intUserOutput;

            Console.WriteLine($"Input the first number to multiply: 2, Input the second number to multiply: 3, Input the third number to multiply: 6. Result: {intUserOutput = varUserInput1 * varUserInput2 * varUserInput3}");
        }
    }
}
