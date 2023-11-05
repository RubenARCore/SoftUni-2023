using System;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 14 20 60 13 7 19 8
                                                                                  // 27
            int givenNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == givenNumber)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                    }
                }
            }

        }
    }
}