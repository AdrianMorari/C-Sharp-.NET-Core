using System;

namespace _30FirstApp
{
    delegate void AccountStateHandler(object sender, AccountEventArgs e);
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message; Sum = sum;
        }
    }
    class Account
    {
        int _sum;
        // AccountStateHandler _del;
        public event AccountStateHandler Added; // Past Participle
        public event AccountStateHandler Adding; // ing-form
        public event AccountStateHandler Withdrawn; // Past Participle
        //public void RegisterHandler(AccountStateHandler del)
        //{
        //    _del += del;
        //}
        //public void UnregisterHandler(AccountStateHandler del)
        //{
        //    _del -= del;
        //}
        public Account(int sum)
        {
            _sum = sum;
        }
        public void Put(int sum)
        {
            if (Adding != null) Adding(this, new AccountEventArgs ($"On account coming {sum}", sum));
            _sum += sum;
            if (Added != null) Added(this, new AccountEventArgs ($"On account have come {sum}", sum));
        }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                if (Withdrawn != null) Withdrawn(this, new AccountEventArgs ($"You have withdraw {sum}", sum));
            }
            else
            {
                if (Withdrawn != null) Withdrawn(this, new AccountEventArgs ($"Not enough money", 0));
            }
        }
    }
    class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Account account = new Account(100);
            //account.RegisterHandler(Display);
            //account.RegisterHandler(ColorDisplay);
            account.Added += new AccountStateHandler(Display);
            account.Withdrawn += Display;
            account.Put(100);
            account.Withdraw(100);
            account.Withdrawn -= Display;
            //account.UnregisterHandler(ColorDisplay);
            account.Withdraw(150);
            //Message message;
            //message = Display;
            //message.Invoke();
            //message();

            //Operation operation = Add;
            //int result = operation.Invoke(4, 5);
            //Console.WriteLine(result);
            //operation = Multiply;
            //result = operation(4, 10);
            //Console.WriteLine(result);
            //DoOperation(4, 12, Add);
            //DoOperation(4, 12, Multiply);

            Console.ReadKey();
        }
        static void DoOperation(int x, int y, Operation operation)
        {
            int res = operation(x, y);
            Console.WriteLine(res);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static void Display(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Sum of transaction : {e.Sum}");
            Console.WriteLine(e.Message);
        }
        //static void ColorDisplay(string message)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine(message);
        //    Console.ResetColor();
        //}
    }
}
