using System;

namespace дз_задание_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши число ");
            int num1 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Напиши число ");
            int num2 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Напиши число ");
            int num3 = Math.Abs(int.Parse(Console.ReadLine()));
            int min1 = Math.Min(num1, num2);
            int min = Math.Min(min1, num3);
            Console.WriteLine($"Минимальное набранное число = {min}");
        }
    }
}
