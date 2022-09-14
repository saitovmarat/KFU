using System;

namespace дз_задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ") ;
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"cos(x) = {Math.Cos(x)}");

        }
    }
}
