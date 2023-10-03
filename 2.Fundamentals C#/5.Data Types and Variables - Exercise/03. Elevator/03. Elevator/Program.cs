using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (number <= capacity)
            {
                Console.WriteLine($"1");
            }
            else if (number % capacity == 0)
            {
                Console.WriteLine(number/capacity);
            }
            else
            {
                Console.WriteLine((number / capacity) +1);
            }
        }
    }
}