using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalSum = 0;

            if ( dayOfWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    totalSum = countOfPeople * 8.45;

                    if(countOfPeople >= 30)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    if(countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                    totalSum = countOfPeople * 10.9;
                }
                else if(groupType == "Regular")
                {
                    totalSum = countOfPeople * 15;

                    if(countOfPeople>= 10 && countOfPeople <= 20)
                    {
                        totalSum -= totalSum * 0.05;
                    }
                }
            }
            else if ( dayOfWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    totalSum = countOfPeople * 9.80;

                    if (countOfPeople >= 30)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                    totalSum = countOfPeople * 15.6;
                }
                else if (groupType == "Regular")
                {
                    totalSum = countOfPeople * 20;

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalSum -= totalSum * 0.05;
                    }
                }
            }
            else if( dayOfWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    totalSum = countOfPeople * 10.46;

                    if (countOfPeople >= 30)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                    totalSum = countOfPeople * 16;
                }
                else if (groupType == "Regular")
                {
                    totalSum = countOfPeople * 22.50;

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalSum -= totalSum * 0.05;
                    }
                }
            }
            Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}