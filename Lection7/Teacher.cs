using MyCSharpProject.Lection5;
using System.Reflection.Emit;

namespace MyCSharpProject.Lection7
{

    public class Teacher : Person
    {
        // properties
        public string Level { get; set; }
        public string[] Subjects { get; set; }
        public List<Student> Students { get; set; }
        public List<CourseClass> CourseClass { get; set; }

        // constructors

        public Teacher(string level, string[] subjects)
        {
            this.Level = level;
            this.Subjects = subjects;
            this.Students = new List<Student>();
            this.CourseClass = new List<CourseClass>();
        }

        public Teacher()
        {
            this.Level = "start";
            this.Subjects = new string [] { };
            this.Students = new List<Student>();
            this.CourseClass = new List<CourseClass>();
        }

        // methods
        public void PrintTeacher()
        {
            Console.WriteLine($"\n \t Level: {Level}; \n \t Subjects:");

            for (int i = 0; i < Subjects.Length; i++)
            {
                Console.WriteLine($"\t \t - {Subjects[i]}");
            }
            Console.WriteLine($"\t \t Students:");
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"\t \t - {Students[i].FirstName} {Students[i].LastName}");
            }
            Console.WriteLine($"\t \t Courses:");
            for (int i = 0; i < CourseClass.Count; i++)
            {
                Console.WriteLine($"\t \t - {CourseClass[i].CourseName}");
            }
        }

        public override string DescribeYourself()
        {
            return ($"\n \t CountryOrigin: {CountryOrigin}; \n \t Subjects {Subjects.Length}; \n \t Students {Students.Count};  \n \t CourseClass {CourseClass.Count}");
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddCourse(CourseClass courseClass)
        {
            CourseClass.Add(courseClass);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void RemoveCourse(CourseClass courseClass)
        {
            CourseClass.Remove(courseClass);
        }
        public int CountStudent()
        {
            return Students.Count;
        }

        public int CountCourse()
        {
            return CourseClass.Count;
        }

    }
}