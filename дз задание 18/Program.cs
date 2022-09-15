using System;

namespace дз_задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 3;
            int maxnums = Math.Max(num1, num2);
            Console.WriteLine(maxnums-(num1+num2-maxnums));
        }
    }
}
