using System;

namespace _8FirstApp
{
    class Program
    {
        // params
        static void Addition(params int[] numbers)
        {
            int result = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            //int z = 10;
            //int c = Sum(z, 15);

            //int z = 5;
            //int d = 6;
            //Console.WriteLine($"Initial value z = {z}");
            //AdditionalVal(z, d);
            //Console.WriteLine($"After AdditionalVal z = {z}");
            //AdditionalRef(ref z, d);
            //Console.WriteLine($"After AdditionalRef z = {z}");

            int perimeter;
            int area;
            GetData(10, 6, out perimeter, out area);
            Console.WriteLine($"Perimeter {perimeter}");
            Console.WriteLine($"Area {area}");

            // optional parameters
            int d1 = Optional(1, 2, 3, 4); 
            int d2 = Optional(1, 2, 3);
            int d3 = Optional(1, 2);

            Addition(new int[] { 1, 2, 3, 4 });
            Addition(2, 3, 4, 5);
            Addition();
            Console.ReadKey();
        }
        static int Optional(int x, int y, int z = 5, int s = 7)
        {
            return x + y + z + s;
        }



        static void GetData(int width, int height, out int perimeter, out int area)
        {
            perimeter = (width + height) * 2;
            area = width * height;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void AdditionalVal(int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionalVal x = {x}");
        }
        static void AdditionalRef(ref int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionalRef x = {x}");
        }
    }
}
