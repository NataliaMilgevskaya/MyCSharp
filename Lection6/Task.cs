using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection6
{


    internal static partial class Task

    {
        public static void Run()
        {
            // Task
            Console.WriteLine(" ");
            Console.WriteLine("Task: \n \t - add class Teacher. The Student class and the Teacher class must have a common base class from which they will be inherited; \n \t - in the base class (from the previous paragraph) add the Describe Yourself method. (Alternative print); \n \t - override the Describe Yourself method in the Student class and in the Teacher class.");
            Console.WriteLine(" ");

            var newPerson = new Person("Ukraine", "Kyiv, Friends Ave, 15");
            var newTeacher = new Teacher("Ivan Nick", new[] { "Math", "C#", "C++" });
            var newStudent = new Student("Ted", "Bill", 12, "Kyiv", new[] { "1", "2", "3"} );

            newPerson.PrintPerson();
            newTeacher.PrintTeacher();
            newStudent.PrintStudent();

            //newPerson.DescribeYourself();
            //newTeacher.DescribeYourself();
            Console.WriteLine("Override");

            string a = newStudent.DescribeYourself();
            Console.WriteLine(a);

            Print(newStudent.DescribeYourself());
            Print(newTeacher.DescribeYourself());
            Print(newPerson.DescribeYourself());

        }

        static void Print(string s) 
        { 
            Console.WriteLine(s); 
        }
    }
}
