using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection3
{
    internal static class Task4
    {
        public static void Run()
        {
            // Task 4
            Console.WriteLine("Task 4. Write a C# program to compute the sum of the first 500 prime numbers.");
            Console.WriteLine(" ");

            int n = 2; // first prime number
            int sum = 0;

            for (int i = 1; i <= 500;) // count prime numbers
            {
                bool isPrimeNumber = true; // set prime number by default is true


                for (int j = n - 1; j >= 2; j--) // devide each checked number to number-1 till devide number is more than 2  (ex for 25 we start deviding with 24... 25/24; 25/23; 25/22...)
                {
                    if (n % j == 0) // if we found one number that gives without remainder, so this checked number is not prime number
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                if (isPrimeNumber == true) // if we didn't change variable isPrimeNumber to false in previous step
                {
                    Console.WriteLine($"Number {n} - is prime number"); // output info about prime number
                    i++; // set new checked number
                    sum = sum + n; // count sum with found prime number with previous prime numbers
                }
                n++;
            }
            Console.WriteLine($"The summ of the first 500 prime numbers is {sum}"); // output info about sum
            Console.WriteLine(" ");
        }
    }
}
