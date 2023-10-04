using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int minedYield = 0;
            int countDays = 0;

            if (input <100)
            {
                Console.WriteLine(countDays);
                Console.WriteLine(minedYield);
                return;
            }

            while (input >= 100)
            {
                countDays++;
                minedYield += input;
                input -= 10;
                minedYield -= 26;


            }

            Console.WriteLine(countDays);
            Console.WriteLine(minedYield-26);
        }
    }
}