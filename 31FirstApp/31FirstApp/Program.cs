using System;

namespace _31FirstApp
{
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message; Sum = sum;
        }
    }
    class Program
    {
        delegate void MessageHandler(string mes);
        delegate void MessageHandler2(string mes, int r);
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation operation = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(operation(10, 20));
            Console.WriteLine(operation(40, 20));
            //MessageHandler handler = delegate (string message)
            //{
            //    Console.WriteLine(message);
            //};
            //handler("Hello");
            Show("Hello world!", delegate 
            {
                Console.WriteLine("anonymous method");
            });
            Console.Read();
        }
        static void Show(string mes, MessageHandler handler)
        {
            handler(mes);
        }
        
        static void Display(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Sum of transaction : {e.Sum}");
            Console.WriteLine(e.Message);
        }
    }
}
