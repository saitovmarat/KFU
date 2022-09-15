using System;

namespace дз_задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 4;
            double arifm = (num1 + num2) / 2;
            double geometr = Math.Sqrt(num1 * num2);
            Console.WriteLine($"Среднее арифметическое = {arifm}");
            Console.WriteLine($"Среднее геометрическое = {geometr}");

        }
    }
}
