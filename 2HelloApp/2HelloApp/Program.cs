using System;

namespace _2HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;
            Console.WriteLine(name);
            name = "Bob";
            Console.WriteLine(name);

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");
            Console.ReadKey();
        }
    }
}
