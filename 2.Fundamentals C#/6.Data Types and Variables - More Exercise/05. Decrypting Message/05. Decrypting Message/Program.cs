using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());

                input += (char)key;

                Console.Write(input);
            }
        }
    }
}