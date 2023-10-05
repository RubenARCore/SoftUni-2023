using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday","Sunday",};

            if (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(dayOfWeek[input-1]);

            }
        }
    }
}