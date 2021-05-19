using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 21, 500, 66 };
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] % 3 == 0)
                    Console.WriteLine(nums[i]);

        }
    }
}
