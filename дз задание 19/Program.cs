using System;

namespace дз_задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            b = c;
            a = b;
            c = a;
            Console.Write("a) ");
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            a= 1;
            b= 2;
            c= 3;
            b = a;
            c = b;
            a = c;
            Console.WriteLine("");
            Console.Write("б) ");
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
        }
    }
}
