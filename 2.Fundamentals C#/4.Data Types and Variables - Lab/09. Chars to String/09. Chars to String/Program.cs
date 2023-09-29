using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] combinedChars = new char[3];

            for (int i = 0; i < combinedChars.Length; i++)
            {
                combinedChars[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join("",combinedChars));
        }
    }
}