using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            while (input != "END")
            {
                int integer;
                double floatingPoint;
                char ch;
                bool boolean;

                if (bool.TryParse(input, out boolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (int.TryParse(input,out integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out floatingPoint))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input,out ch))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }


                input = Console.ReadLine();

            }
        }
    }
}