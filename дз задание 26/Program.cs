using System;

namespace дз_задание_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 8;
            double m = 45;
            double s = 23;
            double overall_h = h + m / 60 + s / 3600;
            Console.WriteLine(overall_h*30);
        }
    }
}
