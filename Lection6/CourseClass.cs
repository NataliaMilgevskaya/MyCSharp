namespace MyCSharpProject.Lection6
{
    class CourseClass
    {
        // properties
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }
        public List<string> Students { get; set; }

        //constructors
        public CourseClass(string courseName, string teacherName, int courseDuration, int numberOfStudents)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            NumberOfStudents = numberOfStudents;
            Students = new List<string>();
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
        }

        //methods
        public void Print()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Teacher Name: {TeacherName}");
            Console.WriteLine($"Course Duration: {CourseDuration}");
            Console.WriteLine($"Number of Students: {NumberOfStudents}");
            Console.WriteLine("Students:");
            if (Students != null)
            {
                foreach (string student in Students)
            {
                Console.WriteLine(student);
            }}
        }

        public void AddStudent(string student)
        {
            Students.Add(student);
            NumberOfStudents++;
        }
    }
}
