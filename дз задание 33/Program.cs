using System;

namespace дз_задание_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты пенсионер? ");
            string otv1 = Console.ReadLine();
            Console.WriteLine("Ты студент? ");
            string otv2 = Console.ReadLine();
            Console.WriteLine("Ты трудоустроен? ");
            string otv3 = Console.ReadLine();
            if ((((otv1 == "Да") || (otv1 == "да")) || ((otv2 == "Да") || (otv2 == "да"))) & ((otv3 == "Нет") || (otv3 == "нет")))
                Console.WriteLine("Получаю кредит");
            else if(((((otv1 == "Да") || (otv1 == "да")) || ((otv2 == "Да") || (otv2 == "да"))) & ((otv3 == "Да") || (otv3 == "да"))) || (((otv1 == "Да") || (otv1 == "да")) & ((otv2 == "Да") || (otv2 == "да"))))
                Console.WriteLine("Не получаю кредит");
        }
    }
}
