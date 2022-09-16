using System;

namespace дз_задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9768977;
            Console.WriteLine($"число сотен  n = {(n / 100) % 10}");
            Console.WriteLine($"число тысяч  n = {(n / 1000) % 10}");

        }
    }
}
