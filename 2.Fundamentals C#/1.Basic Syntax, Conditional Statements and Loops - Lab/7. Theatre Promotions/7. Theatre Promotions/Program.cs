﻿namespace _7._Theatre_Promotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            if (dayType == "Weekday")
            {
                if (age >=0 && age <=18)
                {
                    Console.WriteLine("12$");
                }
                else if (age >= 19 && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (age >= 65 && age <= 122)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (dayType == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (age >= 19 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (age >= 65 && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (dayType == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age >= 19 && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (age >= 65 && age <= 122)
                {
                    Console.WriteLine("10$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}