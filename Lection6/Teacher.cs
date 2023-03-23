namespace MyCSharpProject.Lection6
{

        public class Teacher : Person 
        { 
            // properties
            public string Level { get; set; }
            public string[] Subjects  { get; set; }

            // constructors

            public Teacher (string level, string[] subjects)
            {
                this.Level = level;
                this.Subjects = subjects;
            }

            public Teacher()
            { 
            }

            // methods
            public void PrintTeacher()
            {

                Console.WriteLine($"\n \t Level: {Level}; \n \t Subjects:");

                for (int i = 0; i < Subjects.Length; i++)
                {
                    Console.WriteLine($"\t \t - {Subjects[i]}");
                }
            }

            public override string DescribeYourself()
            {
                return ($"\n \t CountryOrigin: {CountryOrigin}; \n \t Subjects {Subjects.Length}");
            }


    }
    }