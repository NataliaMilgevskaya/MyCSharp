using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection4
{
    internal static class Task1

    { 
        
        static int MaxThreeNumbers (int num1, int num2, int num3)
        {
            int result = 0;

            
            if (num1 >= num2)
                {
                    if (num1 >= num3)
                    {
                        result = num1;
                    }
                    else
                    {
                        if (num3 >= num2)
                        {
                            result = num3;
                        }
                    }
                }
                else
                {
                    result = num2;
                }


                return result;
            }
            
        
        
        
        public static void Run()
        {

            // Task 1
            Console.WriteLine(" ");
            Console.WriteLine("Task 1. Write a C# method to find the largest value from three integer values.");
            Console.WriteLine(" ");

            Console.WriteLine("Input three integer value one by one");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var result= MaxThreeNumbers(num1,num2, num3);
            Console.WriteLine($"The largest value of {num1}, {num2}, {num3} is {result}");

        }
    }
}
