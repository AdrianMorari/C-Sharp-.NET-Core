using System;

namespace _27FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account<int> acc1 = new Account<int>();
            //Account<string> acc2 = new Account<string>();
            //Account<int> acc3 = new Account<int>();

            //acc1.Id = 45; // упаковка

            //acc2.Id = "434";

            //int intId = acc1.Id; // распаковка

            //string strId = acc2.Id;
            //Console.WriteLine($"acc1 : {intId} acc2 : {strId}");

            //Transaction<Account<int>, string> operation =
            //    new Transaction<Account<int>, string>()
            //    {
            //        FromAccount = acc1,
            //        ToAccount = acc3,
            //        Code = "32323"
            //    };
            //Transaction<int, string> operation2 =
            //    new Transaction<int, string>()
            //    {
            //        FromAccount = 3423,
            //        ToAccount = 1111,
            //        Code = "32323"
            //    };

            int x = 34;
            int y = 6;
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x = {x} y = {y}");

            string s1 = "hello";
            string s2 = "bye";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1 = {s1}  s2 = {s2}");
            Console.ReadKey();
        }
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        class Transaction<U, V>
        {
            public U FromAccount { get; set; }
            public U ToAccount { get; set; }
            public V Code { get; set; }
        }
        class Account<T>
        {
            public T Id { get; set; }
            public int Sum { get; set; }
        }
        class Id { }
    }
}
