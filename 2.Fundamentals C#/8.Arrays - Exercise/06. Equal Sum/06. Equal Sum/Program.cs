using System;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 1 2 3 3

            

            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += input[j];
                    }
                    else if (j > i)
                    {
                        rightSum += input[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}