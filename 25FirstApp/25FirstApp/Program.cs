using System;

namespace _25FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Thomas" };
            Person person2 = new Person() { Name = "Victuar" };
            Person person3 = new Person() { Name = "Thomas" };

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person3));

            //Clock clock = new Clock { Hours = 15, Minutes = 45, Seconds = 22 };
            //Console.WriteLine(clock);

            Console.Read();
        }
    }
    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return $"{Hours} : {Minutes} : {Seconds}";
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
            {
                return base.ToString();
            }
            else return Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Person person = (Person)obj;
            return this.Name == person.Name && this.Age == person.Age;
        }
    }
}
