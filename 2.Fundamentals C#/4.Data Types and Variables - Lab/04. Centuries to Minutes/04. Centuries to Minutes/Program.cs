using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            decimal years = input * 100;
            decimal days = Math.Truncate(years * (decimal)365.2422);
            decimal hours = days * 24;
            decimal minutes = hours * 60;

            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}