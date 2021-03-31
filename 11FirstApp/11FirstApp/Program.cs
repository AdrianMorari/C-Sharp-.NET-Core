using System;

namespace _11FirstApp
{
    class Program
    {
        //static (string, int) GetValue((string, int) tuple, int x)
        //{
        //    var result = (name: tuple.Item1, age: tuple.Item2 + x);
        //    return result;
        //}
        static void Main(string[] args)
        {
            //var tuple = GetValue(("Jora", 43), 10);

            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);

            //try...catch...finally
            int[] nums = new int[4];
            try
            {
                //nums[5] = 10;
                //int x = 0;
                //int y = 9 / x;

                Console.WriteLine("Введите строку:");
                string message = Console.ReadLine();

                if (message.Length > 6)
                {
                    throw new Exception("Длина строки больше чем 6");
                }

                Console.WriteLine("End of try block");
            }
            catch(IndexOutOfRangeException iex)
            {
                Console.WriteLine($"Error occured: {iex.Message}");
            }
            catch(DivideByZeroException dex)
            {
                Console.WriteLine($"Error occured: {dex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }

            Console.ReadKey();
        }
    }
}
