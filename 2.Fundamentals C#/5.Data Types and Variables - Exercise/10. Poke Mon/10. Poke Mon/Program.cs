using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            int originalN = n;
            int halfOfN = 0;

            if (y == 0)
            {
                y = 1;
            }

            if (originalN % 2 == 0)
            {
                halfOfN = originalN / 2;
            }

            while (n >= m)
            {
                n -= m;
                count++;

                if (halfOfN == n)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}