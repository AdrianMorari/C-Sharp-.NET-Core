using System;

namespace _5FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            bool c = a == b;
            bool d = a != b;

            bool f = a > b;
            bool e = a < b;
            bool g = a >= b;
            bool h = a <= b;

            bool x1 = (5 > 6) | (4 < 6);
            bool x2 = (5 > 6) | (4 > 6); // false | false => false

            bool x3 = (5 < 6) & (4 < 6); // true | true => true

            // if...else
            int num1 = 8;
            int num2 = 6;

            if (num1 > num2)
            {
                Console.WriteLine("num1 is bigger than num2");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("num1 is lower than num2");
            }
            else Console.WriteLine($"{num1} is equal {num2}");


            // switch...case
            Console.WriteLine("Press Y or N");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "Y": Console.WriteLine("You pressed Y");
                    break;
                case "N": Console.WriteLine("You pressed N");
                    break;
                default: Console.WriteLine("You pressed unknown key");
                    break;
            }
            // Ternary operator op1?op:op3;
            int x = 4;
            int y = 1;
            Console.WriteLine("Press + or -");
            string selection2 = Console.ReadLine();
            int z = selection2 == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
