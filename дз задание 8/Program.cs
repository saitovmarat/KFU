using System;

namespace дз_задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vis = 2;
            int osn_b = 5;
            int osn_m = 1;
            double st = Math.Sqrt(Math.Pow((osn_b-osn_m)/2, 2) + Math.Pow(vis, 2));
            Console.WriteLine(st);
        }
    }
}
