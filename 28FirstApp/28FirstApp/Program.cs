using System;

namespace _28FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            Country country = null;
            string name = "";

            //int? age = 5;
            int? age = null;
            int x = age ?? 10;
            //int x = age.GetValueOrDefault();
            
            Console.WriteLine(x);

            System.Nullable<int> age2 = 45;
            double? d = null;
            d = 3.4;

            //State? stateNullable = null; // new State { Name = "Narnia" };
            //if (stateNullable.HasValue == true)
            //{
            //    State state = stateNullable.Value;
            //    Console.WriteLine(state.Name);
            //}
            //else
            //{
            //    Console.WriteLine("stateNullable is equal to null");
            //}
            
            
            Country? c = null;

            Console.Read();
        }
        struct State
        {
            public string Name { get; set; }
        }
        class Country
        {
            public string Name { get; set; }
        }
    }
}
