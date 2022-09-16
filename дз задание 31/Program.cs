using System;

namespace дз_задание_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Console.WriteLine("Чему равно a? ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно b? ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно c? ");
            double c = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно d? ");
            double d = int.Parse(Console.ReadLine());
            for (int x = -100; x <= 100; x++)
                if ((a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d) == 0)
                    cnt++;
            Console.WriteLine(cnt);
        }
    }
}
