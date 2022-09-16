using System;
using System.Threading;

namespace дз_задание_35._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Привет консоль.");
            Console.WriteLine("-Как тебя зовут?");
            Console.Write("");
            string name = Console.ReadLine();
            Console.WriteLine($"-Привет, {name}");
            Console.WriteLine("-Знаешь ли ты что-нибудь о тайной комнате? ");
            Console.WriteLine("-Да. ");
            Console.WriteLine("-Можешь рассказать о ней? ");
            Console.WriteLine("-Нет ");
            Thread.Sleep(5000);
            Console.WriteLine("-Но могу показать.");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Прикиньте поменял цвет. ВАААУУ! (хз как поменять цвет всей консоли)");
        }
    }
}
