using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} => ");
                input[i] = (double)(decimal)Math.Round(input[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{input[i]}");
            }
        }
    }
}