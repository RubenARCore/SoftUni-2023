using System;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool checker = false;

            for (int j = 0; j < input.Length-1; j++)
            {
                for (int i = j; i < input.Length-1; i++)
                {
                    if (input[j] > input[i+1])
                    {
                        checker = true;
                    }
                    else
                    {
                        checker = false;
                        break;
                    }
                }

                if (checker)
                {
                    Console.Write($"{input[j]} ");
                }
            }

            Console.WriteLine(input[^1]);
        }
    }
}