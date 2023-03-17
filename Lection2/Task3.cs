using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection2
{
    internal static class Task3
    {
        public static void Run()
        {

            // Task 3

            Console.WriteLine("Task 3. Print the result of the specified operations:");

            int
                intOperationOneA = -1,
                intOperationOneB = 4,
                intOperationOneC = 6,

                intOperationTwoA = 35,
                intOperationTwoB = 5,
                intOperationTwoC = 7,

                intOperationThreeA = 14,
                intOperationThreeB = -4,
                intOperationThreeC = 6,
                intOperationThreeD = 11,

                intOperationFourA = 2,
                intOperationFourB = 15,
                intOperationFourC = 6,
                intOperationFourD = 1,
                intOperationFourE = 7,
                intOperationFourF = 2;

            float
                floatOperationOneResult,
                floatOperationTwoResult,
                floatOperationThreeResult,
                floatOperationFourResult;



            Console.WriteLine($"-1 + 4 * 6= {floatOperationOneResult = intOperationOneA + intOperationOneB * intOperationOneC}");
            Console.WriteLine($"( 35+ 5 ) % 7= {floatOperationTwoResult = (intOperationTwoA + intOperationTwoB) % intOperationTwoC}");
            Console.WriteLine($"14 + -4 * 6 / 11= {floatOperationThreeResult = intOperationThreeA + intOperationThreeB * intOperationThreeC / intOperationThreeD}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2= {floatOperationFourResult = intOperationFourA + intOperationFourB / intOperationFourC * intOperationFourD - intOperationFourE % intOperationFourF}");

            
        }
    }
}
