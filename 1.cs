using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите число: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i > 7)
            {
                Console.WriteLine($"Привет");
            }

        }
    }

}