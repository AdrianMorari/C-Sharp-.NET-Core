using System;

namespace _29FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISchool pupil = new Person();
            //IUniversity student = new Person();
            //pupil.Study();
            //student.Study();

            Person person = new Person();
            ISchool p1 = person as ISchool;
            p1.Study();
            IUniversity p2 = person as IUniversity;
            p2.Study();

            //IAccount client = new Client("Thomas", 3000);
            //client.Put(2000);
            //Console.WriteLine(client.CurrentSum);
            //client.Withdraw(1000);
            //Console.WriteLine(client.CurrentSum);

            //Client client2 = client as Client;
            //string name = ((Client)client).Name;
            Console.ReadKey();
        }
    }
    interface ISchool
    {
        void Study();
    }
    interface IUniversity
    {
        void Study();
    }
    class Person : ISchool, IUniversity
    {
        void ISchool.Study()
        {
            Console.WriteLine("Person is studing at school");
        }
        void IUniversity.Study()
        {
            Console.WriteLine("Person is studing at university");
        }
    }
    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }
    interface IClient
    {
        string Name { get; set; }
    }
    interface IClientAccount : IAccount, IClient
    {
        void GetIncome();
    }
    class VipClient : IClientAccount
    {
        public int CurrentSum => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetIncome()
        {
            throw new NotImplementedException();
        }

        public void Put(int sum)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum)
        {
            throw new NotImplementedException();
        }
    }
    class Client : IAccount, IClient
    {
        int _sum;
        public Client(string name, int sum)
        {
            Name = name; _sum = sum;
        }
        public int CurrentSum { get { return _sum; } }

        public string Name { get; set; }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (_sum >= sum) _sum -= sum;
        }
    }
}
