using System;

namespace _10FirstApp
{
    struct User
    {
        public string name;
        public int age;

        User(string n, int a)
        {
            name = n;
            age = a;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"name = {name}, age = {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[2];
            users[0].name = "Bob";
            users[0].age = 22;
            users[1].name = "Liza";
            users[1].age = 28;
            foreach(User user in users)
            {
                user.DisplayInfo();
            }

            User tom = new User();
            int d = tom.age;
            tom.DisplayInfo();
            Console.ReadKey();
        }
    }
}
