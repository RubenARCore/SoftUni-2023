using System;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int firstDigit = inputArr[0];

                for (int i = 0; i < inputArr.Length-1; i++)
                {
                    inputArr[i] = inputArr[i+1];
                }

                inputArr[^1] = firstDigit;
            }

            Console.WriteLine(string.Join(" ", inputArr));

        }
    }
}