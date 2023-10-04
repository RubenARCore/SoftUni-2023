using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openedB = 0;
            int closedB = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();


                if (input == "(")
                {
                    openedB++;
                }
                else if (input == ")")
                {
                    closedB++;
                    if (openedB - closedB != 0)
                    {
                        Console.WriteLine($"UNBALANCED");
                        return;
                    }
                }
            }

            if (openedB == closedB)
            {
                Console.WriteLine($"BALANCED");
            }
            else
            {
                Console.WriteLine($"UNBALANCED");
            }

        }
    }
}