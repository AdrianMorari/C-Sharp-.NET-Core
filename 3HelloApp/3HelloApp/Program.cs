using System;

namespace _3HelloApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Input
            int[] nums = new int[7];
            Console.WriteLine("Enter seven numbrers");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0} number: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            // Sort
            int temp;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // Output
            Console.WriteLine("Array Output");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
