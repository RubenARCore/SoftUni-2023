using System;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];


            for (int i = 1; i <= n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i %2 ==0)
                {
                    firstArr[i-1] = input[1];
                    secondArr[i - 1] = input[0];
                }
                else
                {
                    firstArr[i - 1] = input[0];
                    secondArr[i - 1] = input[1];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}