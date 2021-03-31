using System;
using Accounts;

namespace _16FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Thomas";
            person.Display();

            User user = new User();

            Console.ReadKey();
        }
    }
    class Manager : User
    {
        public void DisplayManager()
        {
            Console.WriteLine($"{name}");
        }
    }
    class Person
    {
        public int age;
        public string name;

        public void Display()
        {
            Console.WriteLine($"{name}");
        }
    }
}
