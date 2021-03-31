using System;

namespace _20FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc1 = new Account(1000, 6);
            //Account acc2 = new Account(900, 5);
            //Account.MinSum = 200;
            //Console.WriteLine(Account.GetSum(15000, 0.66666M, 12));
            //Console.WriteLine(Account.GetSum(1000, 10, 5));

            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();
            Console.WriteLine(user1.Id);
            Console.WriteLine(user3.Id);
            Console.WriteLine(user5.Id);
            User.Display();

            Console.ReadKey();
        }
    }
    class User
    {
        private static int counter = 0;
        public int Id { get; set; }
        static User()
        {
            Console.WriteLine("First user is created");
        }
        public User()
        {
            Id = ++counter;
        }
        public static void Display()
        {
            Console.WriteLine($"{counter}");
        }
    }
    static class Account
    {
        // минимальная допустимая сумма для всех счетов
        private static decimal minSum = 100;
        //public Account(decimal sum, decimal rate)
        //{
        //    if (sum < MinSum) throw new Exception("Недопустимая сумма!");
        //    Sum = sum; Rate = rate; 
        //}
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        //public decimal Sum { get; private set; } // сумма на счете 
        //public decimal Rate{ get; private set; } // процентная ставка

        // подсчёт суммы на счёте через определённый период по определенной ставке
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }
}
