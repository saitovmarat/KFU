using System;

namespace дз_задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чему равно a? ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно b? ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно c? ");
            double c = int.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (Math.Sqrt(D) - b) / 2 * a;
            double x2 = (-Math.Sqrt(D) - b) / 2 * a;
            Console.WriteLine($"Первый корень = {x1}");
            Console.WriteLine($"Второй корень = {x2}");
        }
    }
}
