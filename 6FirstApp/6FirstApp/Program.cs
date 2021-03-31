using System;

namespace _6FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // for
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine($"{i} - {i * i}");
            }

            int n = 7;
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);

            // while
            int j = 5;
            while (j > 0)
            {
                Console.WriteLine(j);
                j--;
            }

            // do...while
            int k = -4;
            do
            {
                Console.WriteLine(k);
                k--;
            }
            while (k > 0);

            // foreach
            Console.ReadKey();
        }
    }
}
