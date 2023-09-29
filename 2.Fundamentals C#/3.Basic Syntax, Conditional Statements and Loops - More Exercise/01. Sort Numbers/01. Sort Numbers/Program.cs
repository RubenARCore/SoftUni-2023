using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[3];

            for (int i = 0; i < 3; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(input);

            for (int i = 3 - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }

        }
    }
}