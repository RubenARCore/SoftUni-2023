using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= input; i++)
            {
                var temp = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                var checker = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", temp, checker);
                total = 0;
                i = temp;
            }
        }
    }
}