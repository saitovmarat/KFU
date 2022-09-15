using System;

namespace дз_задание_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3601;
            Console.Write($"С начала суток прошло { n / 3600} часов, ");
            Console.Write($"{ n / 60} минут ");
            Console.Write($"и {n} секунд.");
        }
    }
}
