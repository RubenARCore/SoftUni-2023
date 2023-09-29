using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double extraSaber = students * 0.1;
            int freeBelts = students / 6;
            double totalSum = 0;

            totalSum += priceLightsabers * (Math.Ceiling(extraSaber) + students);
            totalSum += priceBelts * (students - freeBelts);
            totalSum += priceRobes * students;

            if (totalSum <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - amountOfMoney:f2}lv more.");
            }
        }
    }
}