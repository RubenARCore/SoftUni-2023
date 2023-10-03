using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());
            int fourthInput = int.Parse(Console.ReadLine());

            int firstOperation = firstInput + secondInput;
            int secondOperation = firstOperation / thirdInput;
            int thirdOperation = secondOperation * fourthInput;

            Console.WriteLine(thirdOperation);
        }
    }
}