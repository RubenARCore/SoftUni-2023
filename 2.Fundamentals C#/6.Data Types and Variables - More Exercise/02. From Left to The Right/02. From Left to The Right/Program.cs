using System;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long temp;
                long sum = 0;

                if (input[0] > input[1])
                {
                    while (input[0] != 0)
                    {
                        temp = input[0] % 10;
                        sum += temp;
                        input[0] /= 10;
                    }

                    Console.WriteLine(Math.Abs(sum));
                }
                else
                {
                    while (input[1] != 0)
                    {
                        temp = input[1] % 10;
                        sum += temp;
                        input[1] /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
            }
        }
    }
}