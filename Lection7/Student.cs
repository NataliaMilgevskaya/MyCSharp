namespace MyCSharpProject.Lection7
{
    public class Student : Person
    { 
        
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string[] Courses { get; set; }
        public List<CourseClass> CourseClass { get; set; }

        //constructors
        public Student(string firstName, string lastName, int age, string city, string[] courses)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            Courses = courses;
            CourseClass = new List<CourseClass>();
        }

        public Student(string firstName, string lastName) : this(firstName, lastName, 33, "empty", new[] { "1", "2", "3" })
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student()
        {
            FirstName = "empty";
            LastName = "empty";
            Age = 0;
            City = "empty";
            Courses = new[] { "math", "bio", "logic" };
            CourseClass = new List<CourseClass>();
        }
           //methods
            public void PrintStudent ()
        {

            Console.WriteLine($"\n \t First name: {FirstName}; \n \t Last name: {LastName}; \n \t Age: {Age}; \n \t City: {City} ; \n \t Courses: ");

            for (int i = 0; i < Courses.Length; i++)
            {
                Console.WriteLine($"\t \t - {Courses[i]}");
            }

            Console.WriteLine($"\t Course classes: ");

            for (int i = 0; i < CourseClass.Count; i++)
            {
                Console.WriteLine($"\t \t - {CourseClass[i].CourseName}");
            }
        }

        public void AddCourse(string course)
        {
            // create a new array with the increased size
            string[] newCourses = new string[Courses.Length + 1];

            // copy the existing elements to the new array
            for (int i = 0; i < Courses.Length; i++)
            {
                newCourses[i] = Courses[i];
            }

            // assign the new course to the last index of the new array
            newCourses[newCourses.Length - 1] = course;

            // assign the new array to the Courses property
            Courses = newCourses;
        }
        //public void DeleteCourse(string course)
        //{
        //    int index = Array.IndexOf(Courses, course);
        //    if (index >= 0)
        //    {
        //        // create a new array with the decreased size
        //        string[] newCourses = new string[Courses.Length - 1];

        //        // copy the existing elements except the deleted course to the new array
        //        int j = 0;
        //        for (int i = 0; i < Courses.Length; i++)
        //        {
        //            if (i != index)
        //            {
        //                newCourses[j++] = Courses[i];
        //            }
        //        }

        //        // assign the new array to the Courses property
        //        Courses = newCourses;
        //    }
        //}

        public void DeleteCourse(int index)
        {
            if (index >= 0 && index < Courses.Length)
            {
                // create a new array with the decreased size
                string[] newCourses = new string[Courses.Length - 1];

                // copy the existing elements except the deleted course to the new array
                int j = 0;
                for (int i = 0; i < Courses.Length; i++)
                {
                    if (i != index)
                    {
                        newCourses[j++] = Courses[i];
                    }
                }

                // assign the new array to the Courses property
                Courses = newCourses;
            }
        }

        public override string DescribeYourself()
        {
            return ($"\n \t First name: {FirstName}; \n \t Last name: {LastName}; \n \t Age: {Age}; \n \t City: {City} ; \n \t Courses {Courses.Length}");
        }
        public void AddCourse(CourseClass courseClass)
        {
            CourseClass.Add(courseClass);
        }
        public void RemoveCourse(CourseClass courseClass)
        {
            CourseClass.Remove(courseClass);
        }
        public int CountCourse()
        {
            return CourseClass.Count;
        }
    }
}
