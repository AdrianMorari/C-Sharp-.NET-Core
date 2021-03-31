using System;

namespace _23FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person ("Tucanoff", "Ivan" );
            p1.Display();
            Employee p2 = new Employee ("Smith", "Will", "OAO" );
            p2.Display();
            Employee p3 = new Employee("Jorik", "Vartanov", "Facebook");
            p3.Display();

            Console.ReadKey();
        }
        class Person
        {
            private string _firstName;
            private string _lastName;

            public Person(string name, string surname)
            {
                _firstName = name;
                _lastName = surname;
            }

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value;  }
            }
            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }
            public virtual void Display()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        class Manager : Employee
        {
            public Manager(string name, string surname, string comp) : base(name, surname, comp) { }
            public override void Display()
            {
                Console.WriteLine("This person is Manager");
            }
        }
        class Employee : Person
        {
            private string _company;

            public Employee(string name, string surname, string comp) : base(name, surname)
            {
                _company = comp;
            }
            public string Company
            {
                get { return _company; }
                set { _company = value; }
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Works in " + Company);
            }
        }
    }
}
