using System;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); //2 1 1 2 3 3 2 2 2 1
            Array.Resize(ref input, input.Length+1);

            int count = 1;
            int realNumber = 0;
            int realCount = 1;
            int number = 0;

            for (int i = 0; i < input.Length-1; i++)
            {
                bool checker = true;
                if (input[i] == input[i+1])
                {
                    count++;
                    number = input[i];
                }
                else
                {
                    if (realCount < count)
                    {
                        realCount = count;
                        count = 1;
                        realNumber = number;
                        number = 0;
                        checker = false;
                    }

                    if (checker)
                    {
                        count = 1;
                    }
                }
            }

            for (int i = 0; i < realCount; i++)
            {
                Console.Write($"{realNumber} ");
            }
        }
    }
}