using System;

namespace _1FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator.Add(456, 1);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"The sum of {x} and {y} is {z}");
        }
    }
}
