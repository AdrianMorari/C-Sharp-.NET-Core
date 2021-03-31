using System;

namespace _26FirstApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Person person1 = new Employee("Thomas", "Smith", "Microsoft");
            Person person2 = new Client("Billy Bob", "Thornton", "SomeBank", 5000);
            //int sum = ((Client)person2).Sum;
            //string company = ((Employee)person1).Company;
            //Console.WriteLine(sum);
            //Console.WriteLine(company);

            try
            {
                Client client = (Client)person2;
                int sum = client.Sum;
                Console.WriteLine(sum);
            }
            catch(InvalidCastException iex)
            {
                Console.WriteLine($"{iex.Message}");
            }

            //Client client = person2 as Client;
            //if (client != null)
            //{
            //    int sum = client.Sum;
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine("Преобразование завершилось неудачно");
            //}

            Console.ReadKey();
        }
        abstract class Person
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
                set { _firstName = value; }
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
        class Client : Person
        {
            public string Bank;
            public int Sum { get; set; }
            public Client(string name, string surname, string bank, int sum)
                : base(name, surname)
            {
                Bank = bank;
                Sum = sum;
            }
            public override void Display()
            {
                Console.WriteLine($"Client : {FirstName} {LastName}");
            }
        }
    }
}