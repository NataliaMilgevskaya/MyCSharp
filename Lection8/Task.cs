using Microsoft.VisualBasic;
using MyCSharpProject.Lection5;
using MyCSharpProject.Lection6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject.Lection8
{


    internal static partial class Task

    {
        public static void Run()
        {
            // Task
            Console.WriteLine(" ");
            Console.WriteLine("Task: The purpose of homework is to finalize the project with students and teachers. Make sure that you have completed all of the listed functions or add them:\r\n- displaying all students on the screen (it is obligatory to display all courses for each student)\r\n- displaying all teachers (it is obligatory to display all courses for each teacher)\r\n- displaying all courses (for each course, display the teacher and all students)\r\n- write error handling\r\n- implement the ability to filter when linking students and a teacher by one field (for example, by name. If the name contains a string entered from the console, display these entities).");
            Console.WriteLine(" ");

            var Teacher1 = new Teacher("Main teacher", new[] { "Math", "C#", "C++" });
            var Teacher2 = new Teacher("Second teacher", new[] { "Geo", "Religy", "Hole C++" });
            var Teacher3 = new Teacher("Third teacher", new[] { "Liter", "C#", "Bio" });
            
            var Nataly = new Student("Natalia", "Milgevskaya", 11, "Kharkiv", new[] { "Math", "C++", "C#" });
            var Semen = new Student("Semen", "Semenovskiy", 54, "Riga", new[] { "Logic", "C++", "C#" });
            var Mary = new Student("Mary", "Mio", 11, "Kharkiv", new[] { "Math", "C++", "C#" });
            var Serge = new Student("Serge", "Semenovskiy", 54, "Riga", new[] { "Logic", "C++", "C#" });
            var Olla = new Student("Olla", "Vee", 11, "Kharkiv", new[] { "Math", "C++", "C#" });
            var Jim = new Student("Jim", "Semenovskiy", 54, "Riga", new[] { "Logic", "C++", "C#" });
            var Grey = new Student("Grey", "Yellow", 11, "Kharkiv", new[] { "Math", "C++", "C#" });
            var Dren = new Student("Dren", "Boin", 54, "Riga", new[] { "Logic", "C++", "C#" });

            var CourseJS = new CourseClass("JS", "Mr.Clever", 3, 12);
            var CourseC = new CourseClass("C++", "Mr.Clever", 3, 12);
            var CourseCSh = new CourseClass("C#", "Mr.Clever", 3, 12);

            Teacher1.AddStudent(Nataly);
            Teacher1.AddStudent(Semen);
            Teacher2.AddStudent(Mary);
            Teacher2.AddStudent(Serge);
            Teacher2.AddStudent(Olla);
            Teacher3.AddStudent(Jim);
            Teacher3.AddStudent(Grey);
            Teacher3.AddStudent(Dren);
            
            Teacher1.AddCourse(CourseJS);
            Teacher1.AddCourse(CourseC);
            Teacher1.AddCourse(CourseCSh);
            Teacher2.AddCourse(CourseJS);
            Teacher3.AddCourse(CourseC);
            Teacher3.AddCourse(CourseCSh);


            List<Student> students = new List<Student>();

            students.Add(Nataly);
            students.Add(Semen);
            students.Add(Mary);
            students.Add(Serge);
            students.Add(Olla);
            students.Add(Jim);
            students.Add(Grey);
            students.Add(Dren);


            Console.WriteLine($"We have {students.Count} students. The list if them above:");
            foreach (var student in students)
            {
                student.PrintStudent();
            }

            List <Teacher> teachers = new List<Teacher>();

            teachers.Add(Teacher1);
            teachers.Add(Teacher2);
            teachers.Add(Teacher3);
            
            Console.WriteLine($"We have {teachers.Count} teachers. The list if them above:");
            foreach (var teacher in teachers)
            {
                teacher.PrintTeacher();
            }

            List<CourseClass> courseClasses = new List<CourseClass>();

            courseClasses.Add(CourseC);
            courseClasses.Add(CourseCSh);
            courseClasses.Add(CourseJS);

            CourseC.AddStudentNew(Nataly);
            CourseJS.AddStudentNew(Semen);
            CourseCSh.AddStudentNew(Mary);
            CourseCSh.AddStudentNew (Serge);
            CourseCSh.AddStudentNew(Grey);

            Console.WriteLine($"We have {courseClasses.Count} courses. The list if them above:");
            foreach (var course in courseClasses)
            {
                course.Print();
            }









        }


    }
}
