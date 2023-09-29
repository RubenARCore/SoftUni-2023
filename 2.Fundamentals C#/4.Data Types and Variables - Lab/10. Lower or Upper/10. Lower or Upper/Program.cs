using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            bool test = char.IsUpper(input);

            if (test)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

            //Алтернативно Решение

            //char ch = char.Parse(Console.ReadLine());

            //int ascii = ch;

            //if (ascii >= 65 && ascii <= 90)
            //{
            //    Console.WriteLine($"upper-case");
            //}
            //else
            //{
            //    Console.WriteLine($"lower-case");
            //}
        }
    }
}