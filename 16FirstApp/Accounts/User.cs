using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class User
    {
        protected internal int age;
        protected internal string name;

        public void Display()
        {
            Console.WriteLine($"{name}");
        }
        private class UserAccount
        {
            private string password;
        }
    }
    internal class Employee : User
    {
        public void DisplayEmployee()
        {
            Console.WriteLine($"{name}");
        }
    }
}
