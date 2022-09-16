using System;

namespace дз_задание_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int num = 9;
            for (int i = 1; i <= num; i++)
                if (num % i == 0)
                    cnt += 1;
            Console.WriteLine(cnt);
        }
    }
}
