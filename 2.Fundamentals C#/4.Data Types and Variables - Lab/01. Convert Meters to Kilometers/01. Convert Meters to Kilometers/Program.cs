﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            input /= 1000;

            Console.WriteLine($"{input:f2}");
        }
    }
}