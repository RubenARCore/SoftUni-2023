using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Array.Reverse(input);

            Console.WriteLine(string.Join("", input));
        }
    }
}