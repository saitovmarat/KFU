using System;

namespace дз_задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num1 = new Random();
            int value1 = num1.Next();            
            Random num2 = new Random();
            int value2 = num2.Next();            
            Random num3 = new Random();
            int value3 = num3.Next();            
            Random num4 = new Random();
            int value4 = num4.Next();
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
        }
    }
}
