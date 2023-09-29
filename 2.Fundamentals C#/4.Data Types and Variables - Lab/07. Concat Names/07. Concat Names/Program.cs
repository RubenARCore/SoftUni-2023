using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] inputNames = new string[2];

            for (int i = 0; i < inputNames.Length; i++)
            {
                inputNames[i] = Console.ReadLine();
            }

            string delimiter = Console.ReadLine()!;

            Console.WriteLine(string.Join(delimiter, inputNames));

        }
    }
}