using System;

namespace _18FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Thomas";
            person.Age = 18;
            Console.WriteLine(person.Age);
            person.Age = 20000;
            Console.WriteLine(person.Age);

            person.FirstName = "Thomas";
            person.LastName = "Smith";
            Console.WriteLine(person.FullName);

            Console.ReadKey();
        }
        class Person
        {
            private int age;
            public int Age
            {
                get { return age; }
                set 
                { 
                    if (value >= 0 && value < 120)
                    age = value; 
                }
            }
            public string FullName
            {
                get { return $"{firstName} {lastName}"; }
            }
            public string firstName;
            public string FirstName
            {
                set { firstName = value; }
            }

            public string lastName;
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
        }
    }
}
