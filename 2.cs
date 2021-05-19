using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            if (name == "Вячеслав")
            {
                Console.WriteLine($"Привет Вячеслав");
            }
            else
            {
                Console.WriteLine($"Нет такого имени");
            }
        }
    }

}