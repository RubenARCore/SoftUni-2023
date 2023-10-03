using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double topResult = 0;
            string kegName = String.Empty;
            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                double  radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double result = Math.PI * radius * radius * height;

                if (topResult < result)
                {
                    topResult = result;
                    kegName = name;
                }
            }

            Console.WriteLine(kegName);
        }
    }
}