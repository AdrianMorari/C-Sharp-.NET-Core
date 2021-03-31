using System;

namespace _7FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4 };

            //int n = numbers[0];
            //numbers[0] = 7;
            //Console.WriteLine(numbers[3]);

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            string s = Hello();
            int c = Sum();
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static string Hello()
        {
            return "Hello World!";
        }
        static int Sum()
        {
            int x = 3;
            int y = 4;
            int z = x + y;
            return z;
        }
        static void Method1()
        {
            Console.WriteLine("Method1 is called!");
        }
        static void Method2()
        {
            Console.WriteLine("Method2 is called!");
        }
    }
}
