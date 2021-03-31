using System;

namespace _13FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom");
            //tom.name = "Tom";
            //tom.age = 30;
            tom.Info();

            User bob = new User("Bob", 29);
            bob.Info();

            User jicu = new User { name = "Jicu", age = 42 };
            jicu.Info();

            Console.ReadKey();
        }
    }
}
