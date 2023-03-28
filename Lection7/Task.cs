using Microsoft.VisualBasic;
using MyCSharpProject.Lection6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection7
{


    internal static partial class Task

    {
        public static void Run()
        {
            // Task
            Console.WriteLine(" ");
            Console.WriteLine("Task: \n \t - add a collection of students to the teacher; \n \t - add a collection of students to the course; \n \t - add a collection of courses to a student; \n \t - add a collection of courses to the teacher.");
            Console.WriteLine(" ");

            var Teacher1 = new Teacher("Main teacher", new[] { "Math", "C#", "C++" });
            var Nataly = new Student("Natalia", "Milgevskaya", 11, "Kharkiv", new[] { "Math", "C++", "C#" });
            var Semen = new Student("Semen", "Semenovskiy", 54, "Riga", new[] { "Logic", "C++", "C#" });
            var CourseJS = new CourseClass("JS", "Mr.Clever", 3, 12);

            //Nataly.PrintStudent();
            Teacher1.PrintTeacher();

            Teacher1.AddStudent(Nataly);
            Teacher1.PrintTeacher();


            Teacher1.AddStudent(Semen);
            Teacher1.PrintTeacher();


            Teacher1.AddCourse(CourseJS);
            Teacher1.PrintTeacher();
            Console.WriteLine($"\t \t Number of students: {Teacher1.CountStudent()}");
            Console.WriteLine($"\t \t Number of courses: {Teacher1.CountCourse()}");

            Teacher1.RemoveStudent(Nataly);
            Teacher1.RemoveCourse(CourseJS);
            Teacher1.PrintTeacher();
            Console.WriteLine($"\t \t Number of students: {Teacher1.CountStudent()}");
            Console.WriteLine($"\t \t Number of courses: {Teacher1.CountCourse()}");

            CourseJS.CountStudentNew();
            CourseJS.Print();
            Console.WriteLine($"Number of students for course {CourseJS.CourseName}: {CourseJS.CountStudentNew()}");
            CourseJS.AddStudentNew(Nataly);
            CourseJS.AddStudentNew(Semen);
            CourseJS.CountStudentNew();
            Console.WriteLine($"Number of students for course {CourseJS.CourseName}: {CourseJS.CountStudentNew()}");
            CourseJS.RemoveStudentNew(Semen);
            Console.WriteLine($"Number of students for course {CourseJS.CourseName}: {CourseJS.CountStudentNew()}");

            Nataly.AddCourse(CourseJS);
            Nataly.PrintStudent();
            Nataly.AddCourse(CourseJS.CourseName);
            Nataly.PrintStudent();
            Nataly.AddCourse(CourseJS);
            Nataly.AddCourse(CourseJS);
            Nataly.AddCourse(CourseJS);
            Nataly.PrintStudent();
            Nataly.RemoveCourse(CourseJS);
            Nataly.PrintStudent();
            Console.WriteLine($"Number of courses for student {Nataly.FirstName} {Nataly.LastName}: {Nataly.CountCourse()}");



        }
    }
}
