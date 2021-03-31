using System;

namespace _14FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate(5);
            State state1 = new State();
            Country country1 = new Country();
            Console.ReadKey();
        }

        static void Calculate(int t)
        {
            object x = 6;
            int y = 7;
            int z = y + t;
        }
        struct State
        {
            public int x;
            public int y;
        }
        class Country
        {
            public int x;
            public int y;
        }
    }
}
