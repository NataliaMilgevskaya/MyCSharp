namespace MyCSharpProject.Lection8

{


        public class Person
        {
            // properties
            public string CountryOrigin { get; set; }

            public string Address { get; set; }

            public string [] Languages { get; set; }

            // constructors

            public Person(string countryOrigin, string address, string[] languages)
            { 
                CountryOrigin = countryOrigin;
                Address = address;
                Languages = languages;
            }

            public Person(string countryOrigin, string address) : this(countryOrigin, address, new[] { "Ukrainian", "English", "" })
            {
                CountryOrigin = countryOrigin;
                Address = address;
            }

            public Person()
            { 

            }

            // methods
            public void PrintPerson()
            {

                Console.WriteLine($"\n \t CountryOrigin: {CountryOrigin}; \n \t Address: {Address}; \n \t Languages:");

                for (int i = 0; i < Languages.Length; i++)
                {
                    Console.WriteLine($"\t \t - {Languages[i]}");
                }
            }

            public virtual string DescribeYourself()
            {

                Console.WriteLine($"Base class");
                return "";
              
            }

    }
    }
