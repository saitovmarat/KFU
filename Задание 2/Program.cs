using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2");
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int b = int.Parse(Console.ReadLine());
            int del = a / b;
            Console.WriteLine($"Деление {del}");
        }
    }
}
