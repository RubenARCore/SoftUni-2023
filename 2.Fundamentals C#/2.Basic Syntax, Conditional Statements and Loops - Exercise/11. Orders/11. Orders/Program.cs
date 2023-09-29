using System;
using System.Diagnostics;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 0; i < orders; i++)
            {
                double sumPerOrder = 0;
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                sumPerOrder = ((days * capsuleCount) * priceCapsule);
                totalSum += sumPerOrder;
                Console.WriteLine($"The price for the coffee is: ${sumPerOrder:f2}");

            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}