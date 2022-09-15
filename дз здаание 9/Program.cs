using System;

namespace дз_здаание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int konf = 2;
            int pech = 3;
            int yabl = 4;
            Console.WriteLine("Сколько вы взяли кг конфет? ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько вы взяли кг печенья? ");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько вы взяли кг яблок? ");
            double z = int.Parse(Console.ReadLine());
            Console.WriteLine($"С вас {konf * x + pech * y + yabl * z} руб");
        }
    }
}
