using System;

namespace _24FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human h = new Human();
            //Person person = new Person("Jorik", "Vartanov");
            Person client = new Client("Thomas", "Bezos", 2000);
            Person employee = new Employee("Billy Bob", "Thornton", "mechanic");
            client.Display();
            employee.Display();
            Console.ReadKey();
        }
    }
    abstract class Human
    {
        public string Name { get; set; }
    }
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string name, string surname)
        {
            FirstName = name; LastName = surname;
        }
        public abstract void Display();
    }
    abstract class Figure
    {
        public abstract float Perimeter();
        public abstract float Square();
    }
    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public override float Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        public override float Square()
        {
            return Height * Width;
        }
    }

    class Client : Person
    {
        public int Sum { get; set; }
        public Client(string name, string surname, int sum)
            : base (name, surname)
        {
            Sum = sum;
        }
        public override void Display()
        {
            Console.WriteLine($"Client : {FirstName} {LastName}");
        }
    }
    class Employee : Person
    {
        public string Position { get; set; }
        public Employee(string name, string surname, string pos)
            : base(name, surname)
        {
            Position = pos;
        }
        public override void Display()
        {
            Console.WriteLine($"Employee : {FirstName} {LastName}");
        }
    }
}
