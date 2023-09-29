using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");

            double dul = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            double sh = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            double V = double.Parse(Console.ReadLine());

            V = (dul * sh * V) / 3;

            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}