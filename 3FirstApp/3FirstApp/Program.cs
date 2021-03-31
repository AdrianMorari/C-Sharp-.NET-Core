using System;

namespace _3FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int z = x + 5;
            int y = x * 5;
            Console.WriteLine(z);
            Console.WriteLine(y);

            int a = 3;
            int b = 5;
            int c = 40;
            int d = (c-(-- b)) * a;
            Console.WriteLine($"a={a} b={b} c={c} d={d}");

            Console.ReadKey();
        }
    }
}
