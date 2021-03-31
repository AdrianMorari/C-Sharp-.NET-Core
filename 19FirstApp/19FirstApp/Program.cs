using System;

namespace _19FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(1, 2);
            calc.Add(1, 2, 3, 4);
            calc.Add(1, 2, 3);
            calc.Add(1.2, 5);

            Console.ReadKey();
        }
        class Calculator
        {
            public void Add(int x, int y)
            {
                int result = x + y;
                Console.WriteLine($"Result: {result}");
            }
            public int Add(int x, int y, int z, int t)
            {
                int result = x + y + z + t;
                Console.WriteLine($"Result: {result}");
                return x + y;
            }

            public void Add(int x, int y, int z)
            {
                int result = x + y + z;
                Console.WriteLine($"Result: {result}");
            }

            public void Add(double x, double y)
            {
                double result = x + y;
                Console.WriteLine($"Result: {result}");
            }
        }

    }
}
