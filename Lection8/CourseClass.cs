using System.Reflection.Emit;

namespace MyCSharpProject.Lection8
{
    public class CourseClass
    {
        // properties
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfTeachers { get; set; }
        public List<string> Students { get; set; }

        public List<Student> StudentNew { get; set; }

        public List<Teacher> TeacherNew { get; set; }

        //constructors
        public CourseClass(string courseName, string teacherName, int courseDuration, int numberOfStudents)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            NumberOfStudents = numberOfStudents;
            
            Students = new List<string>();
            StudentNew = new List<Student>();
            TeacherNew = new List<Teacher>();
         
        }

        public CourseClass(string courseName, string teacherName, int courseDuration, int numberOfStudents, List<string> students) : this(courseName, teacherName, courseDuration, numberOfStudents)
        {
            Students = students;
        }

        public CourseClass() : this("new course", "not selected", 12, 10)// Default values
        {
            Students = new List<string>();
        }

        public CourseClass(string courseName, string teacherName, int courseDuration, List<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.CourseDuration = courseDuration;
            this.Students = students;
            StudentNew = new List<Student>();
            TeacherNew = new List<Teacher>();
        }

        //methods
        public void Print()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Teacher Name: {TeacherName}");
            Console.WriteLine($"Course Duration: {CourseDuration}");
            Console.WriteLine($"Number of Students: {NumberOfStudents}");
            Console.WriteLine("StudentNew:");
            
            for (int i = 0; i < StudentNew.Count; i++)
            {
                Console.WriteLine($"\t \t - {StudentNew[i].FirstName} {StudentNew[i].LastName}");
            }
           
            Console.WriteLine("TeacherNew:");

            for (int i = 0; i < TeacherNew.Count; i++)
            {
                Console.WriteLine($"\t \t - {TeacherNew[i].Level}");
            }
        }

        public void AddStudent(string student)
        {
            Students.Add(student);
            NumberOfStudents++;
        }

        public void AddStudentNew(Student  studentNew)
        {
            StudentNew.Add(studentNew);
        }

        public void RemoveStudentNew(Student studentNew)
        {
            StudentNew.Remove(studentNew);
        }

        public int CountStudentNew()
        {
            return StudentNew.Count;
        }

        public void AddTeacherNew(Teacher teacherNew)
        {
            TeacherNew.Add(teacherNew);
        }
    }
}
