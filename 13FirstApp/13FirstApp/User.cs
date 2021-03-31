using System;
using System.Collections.Generic;
using System.Text;

namespace _13FirstApp
{
    class User
    {
        public string name;
        public int age;

        public User()
        {
        }
        public User(string name)
        {
            this.name = name;
        }
        public User(string n, int a) : this(n)
        {
            age = a;
        }

        public void Info()
        {
            Console.WriteLine($"{name} - {age}");
        }
    }
}
