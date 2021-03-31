using System;

namespace _4HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetHello();
            int sum = GetSum();
            Console.WriteLine(message);
            Console.WriteLine(sum);

            int result = Sum(10, 15);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayGoodbye()
        {
            Console.WriteLine("GoodBye");
        }
        static string GetHello() => "Hello";
        static int GetSum()
        {
            int x = 2;
            int y = 3;
            int z = x + y;
            return z;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

    }
}

