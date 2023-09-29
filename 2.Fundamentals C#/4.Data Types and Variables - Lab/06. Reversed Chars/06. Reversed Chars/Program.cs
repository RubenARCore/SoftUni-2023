using System;

namespace _06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[3];

            for (int i = 0; i < 3; i++)
            {
                input[i] = char.Parse(Console.ReadLine());
            }

            Array.Reverse(input);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}