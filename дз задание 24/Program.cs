using System;

namespace дз_задание_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "7048";
            Console.WriteLine($"Число {num}");
            Console.WriteLine($"а) {num[3]}{num[2]}{num[1]}{num[0]}");
            Console.WriteLine($"б) {num[1]}{num[0]}{num[3]}{num[2]}");
            Console.WriteLine($"в) {num[0]}{num[2]}{num[1]}{num[3]}");
            Console.WriteLine($"г) {num[2]}{num[3]}{num[0]}{num[1]}");
        }
    }
}
