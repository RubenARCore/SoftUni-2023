using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                sum += input[i];
                Console.Write($"{input[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}