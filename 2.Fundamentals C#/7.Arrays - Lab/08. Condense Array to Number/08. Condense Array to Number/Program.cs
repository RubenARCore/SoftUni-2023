using System;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] condensed = new int[number.Length];

            while (number.Length != 1)
            {
                for (int i = 0; i < number.Length - 1; i++)
                {
                    condensed[i] = number[i] + number[i + 1];

                }
                Array.Resize(ref condensed, condensed.Length - 1);
                number = condensed;
            }
            Console.WriteLine(number[0]);
        }
    }
}