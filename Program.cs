using System;

Console.WriteLine("My name is Natalia Milgevska");
Console.WriteLine(" ");
Console.WriteLine("Hometask Lection 2");
Console.WriteLine(" ");
Console.WriteLine("Write a C# Sharp program");
Console.WriteLine("    - print the sum of two numbers");
Console.WriteLine("    - print the result of dividing two numbers");
Console.WriteLine("    - print the result of the specified operations:");
Console.WriteLine("           |    -1 + 4 * 6");
Console.WriteLine("           |    ( 35+ 5 ) % 7");
Console.WriteLine("           |    14 + -4 * 6 / 11");
Console.WriteLine("           |    2 + 15 / 6 * 1 - 7 % 2");
Console.WriteLine("    - swap two numbers");
Console.WriteLine("           |   Test Data:");
Console.WriteLine("           |    Input the First Number : 5");
Console.WriteLine("           |    Input the Second Number : 6");
Console.WriteLine("           |   Expected Output after Swapping:");
Console.WriteLine("           |    First Number : 6");
Console.WriteLine("           |    Second Number : 5");
Console.WriteLine("    - print the output of multiplication of three numbers which will be entered by the user");
Console.WriteLine("           |   Test Data:");
Console.WriteLine("           |    Input the first number to multiply: 2");
Console.WriteLine("           |    Input the second number to multiply: 3");
Console.WriteLine("           |    Input the third number to multiply: 6");

// Task 1, 2
Console.WriteLine("Task 1. Print the sum of two numbers");
int a = 77, b = 88;
float c = 0;

Console.WriteLine($"77+88= {c = a + b}"); //print the sum of two numbers

Console.WriteLine("Task 2. Print the result of dividing two numbers");
Console.WriteLine($"77/88= {c = a / b}"); //print the result of dividing two numbers

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



Console.WriteLine($"-1 + 4 * 6= {floatOperationOneResult = intOperationOneA + intOperationOneB*intOperationOneC}");
Console.WriteLine($"( 35+ 5 ) % 7= {floatOperationTwoResult = (intOperationTwoA + intOperationTwoB)%intOperationTwoC}");
Console.WriteLine($"14 + -4 * 6 / 11= {floatOperationThreeResult = intOperationThreeA+ intOperationThreeB*intOperationThreeC/intOperationThreeD}");
Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2= {floatOperationFourResult = intOperationFourA + intOperationFourB / intOperationFourC * intOperationFourD - intOperationFourE % intOperationFourF}");

// Task 4

Console.WriteLine("Task 4. Swap two numbers");

int
    d = 5,
    e = 6,
     f,
     g;

Console.WriteLine($"Input the First Number: {d}. Output after Swapping: {f = ++d}");
Console.WriteLine($"Input the First Number: {e}. Output after Swapping: {g = --e}");

// Task 5
Console.WriteLine("Task 5. Print the output of multiplication of three numbers which will be entered by the user");

var varUserInput1 = int.Parse(Console.ReadLine());
var varUserInput2 = int.Parse(Console.ReadLine());
var varUserInput3 = int.Parse(Console.ReadLine());

int intUserOutput;

Console.WriteLine($"Input the first number to multiply: 2, Input the second number to multiply: 3, Input the third number to multiply: 6. Result: {intUserOutput = varUserInput1 * varUserInput2 * varUserInput3}");


//using System;

//namespace MyCSharpProject
//{ 
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("My name is Natalia Milgevska");


//        }
//    }
//}
