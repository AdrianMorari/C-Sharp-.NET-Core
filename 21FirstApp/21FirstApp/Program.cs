using System;

namespace _21FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23};
            Counter c2 = new Counter { Value = 45};

            bool result = c1 > c2;
            Console.WriteLine(result);
            Counter c3 = c2 + c1;
            Console.WriteLine(c3.Value);
            c1++;
            ++c1;

            Console.ReadKey();
        }
    }
    //можем перегрузить - , !, ~, ++, --, +, -, *, /, ==, !=, <, >, <=, >=, &&, ||, +=, -=, *=
    //не можем перегрузить =, ?:
    class Counter
    {
        public int Value { get; set; }
        public static Counter operator ++(Counter c1)
        {
            //c1.Value = c1.Value + 1;
            return new Counter { Value = c1.Value + 10};
        }
        public static Counter operator + (Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }
        public static int operator +(Counter c1, int x)
        {
            return c1.Value + x;
        }
        public static bool operator > (Counter c1, Counter c2)
        {
                return c1.Value > c2.Value;                 // можно так
        }
        public static bool operator < (Counter c1, Counter c2)
        {
            if (c1.Value < c2.Value)
                return c1.Value < c2.Value;                 // можно и так
            else
                return false;
        }
    }
}
