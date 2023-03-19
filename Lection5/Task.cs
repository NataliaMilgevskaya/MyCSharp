using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection5
{


    internal static class Task

    {

        public static void Run()
        {
            // Task
            Console.WriteLine(" ");
            Console.WriteLine("Task. Create a student class and describe its main characteristics: \n \t - first name, \n \t - last name, \n \t - age, \n \t - city, \n \t - courses attended (an array of courses).");
            Console.WriteLine("Describe the following actions: \n \t 1. Print (output basic information), \n \t  2. Add one course to the student (add a new course to the course array), \n \t 3. Delete a course from a student.");

            Console.WriteLine("Create a course class and describe its main characteristics: \n \t - course name, \n \t - teacher name, \n \t - course duration, \n \t - number of students.");
            Console.WriteLine("Describe the following actions: \n \t 1. Print (output basic information), \n \t 2. Add a student to the course group (add one student to the number of students).");

            Console.WriteLine("for each of the classes create a chain of calling constructors.");

            Console.WriteLine(" ");
            Console.WriteLine("To create new student input next information:");
            Console.WriteLine("First name");

            var a = Console.ReadLine();
            Console.WriteLine("Last name");

            var b = Console.ReadLine();
            Console.WriteLine("Age");

            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("City");
            var d = Console.ReadLine();

            Console.WriteLine("3 courses attended:");
            var e = Console.ReadLine();
            var f = Console.ReadLine();
            var g = Console.ReadLine();
            string[] arrayCourses = { e, f, g };
            int count = arrayCourses.Length;

            var student1 = new Student();
            var student2 = new Student(a, b);
            var student3 = new Student(student2.LastName, student2.FirstName, c, d, arrayCourses);


            student1.Print();
            Console.WriteLine(student1.FirstName);

            student2.Print();
            Console.WriteLine(student2.FirstName);

            student3.Print();
            Console.WriteLine(student3.FirstName);

            Console.WriteLine("To add new coirse to student3 courses array - input new string value");
            var newCourse = Console.ReadLine();
            student3.AddCourse(newCourse);
            student3.Print();

            Console.WriteLine("To delete one of the course - input int value - order of the course");
            int varSelectCourseToDelete = int.Parse(Console.ReadLine());
            student3.DeleteCourse(varSelectCourseToDelete);
            student3.Print();

            var courseClass1 = new CourseClass();
            var courseClass2 = new CourseClass("C#", "Teacher One", 2, 8);
            var courseClass3 = new CourseClass("C++", "Teacher Two", 10, new List<string> { student1.FirstName, student2.FirstName, student3.FirstName });


            courseClass1.Print();
            courseClass2.Print();

            Console.WriteLine(student3.FirstName);
            courseClass3.Print();
            courseClass3.AddStudent(student3.FirstName);
            courseClass3.Print();

        }
    }
}
