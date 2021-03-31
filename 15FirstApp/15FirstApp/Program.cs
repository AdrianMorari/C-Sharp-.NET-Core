using System;

namespace _15FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User { name = "Thomas", age = 32 };
            //ChangeUser(ref user1);
            //Console.WriteLine($"{user1.name} - {user1.age}");

            Person person1 = new Person();
            ChangePerson(ref person1);
            Console.WriteLine($"{person1.name} - {person1.age}");

            Console.ReadKey();
        }

        static void ChangePerson(ref Person person)
        {
            person.name = "Valera";
            person.age = 12;
            person = new Person { name = "Bill", age = 18 };
        }
        static void ChangeUser(ref User user)
        {
            user.name = "Thomas";
            user.age = 30;
        }
    }

    struct User
    {
        public int age;
        public string name;
    }
    class Person
    {
        public int age;
        public string name;
    }
}
