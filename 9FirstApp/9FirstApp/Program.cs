using System;

namespace _9FirstApp
{
    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday,
        Sunday
    }
    class Program
    {
        enum Operation
        {
            Add,
            Substract,
            Multiply,
            Divide
        }
        
        static void ApplyOperation(double x, double y, Operation op)
        {
            double result = 0.0;
            switch (op)
            {
                case Operation.Add : result = x + y;
                    break;
                case Operation.Substract : result = x - y;
                    break;
                case Operation.Multiply: result = x * y;
                    break;
                case Operation.Divide : result = x / y;
                    break;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            //Days day;
            //day = Days.Saturday;
            //Console.WriteLine((int)day);
            ApplyOperation(10, 15, Operation.Add);
            ApplyOperation(10, 15, Operation.Substract);
            ApplyOperation(10, 15, Operation.Multiply);
            ApplyOperation(10, 15, Operation.Divide);
            Console.ReadKey();
        }
    }
}
