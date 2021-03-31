using System;

namespace _22FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter { Seconds = 115032 };
            Timer timer1 = counter1;
            Console.WriteLine($"{timer1.Hours}:{timer1.Minutes}:{timer1.Seconds}");
            Counter counter3 = (Counter)timer1;
            Console.WriteLine(counter3.Seconds);

            int x = counter1.Seconds;
            byte y = (byte)x; // явное преобразование от int к byte
            int z = y;        // неявное преобразование от byte к int

            Console.ReadKey();
        }
    }
    class Counter
    {
        public int Seconds { get; set; }
        public static implicit operator Counter(int x)
        {
            return new Counter { Seconds = x };
        }
        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Counter { Seconds = h + m + timer.Seconds };
        }
        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds - h * 3600) / 60;
            int s = counter.Seconds - h * 3600 - m * 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }
    }
    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
}
