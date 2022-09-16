using System;

namespace дз_задание_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 2;
            int a2 = 3;
            int d = a2 - a1;
            Console.WriteLine("Какой элемент последовательности хочешь узнать? ");
            int n = int.Parse(Console.ReadLine());
            int an = a1 + d * (n - 1);
            Console.WriteLine($"{n} число последовательности = {an}");
        }
    }
}
