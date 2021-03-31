using System;

namespace _4FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2;
            int y1 = 5;
            Console.WriteLine(x1 & y1);

            int x2 = 4;
            int y2 = 5;
            Console.WriteLine(x2 | y2);

            byte a = 4;
            byte b = (byte)(a + 70);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
