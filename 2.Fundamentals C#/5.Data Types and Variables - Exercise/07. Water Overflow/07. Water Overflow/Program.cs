using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input + sum > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    sum += input;
                }

            }

            Console.WriteLine(sum);
        }
    }
}