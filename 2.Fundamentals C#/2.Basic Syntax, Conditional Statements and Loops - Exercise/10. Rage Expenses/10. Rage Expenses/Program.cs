using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lostGames = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalSum = 0;

            double lostHeadset = 0;
            double lostMouse = 0;
            double lostDisplay = 0;


            for (int i = 1; i <= lostGames; i++)
            {
                lostHeadset++;
                lostMouse++;

                if (lostHeadset == 2 && lostMouse == 3)
                {
                    totalSum += keyboardPrice;
                    lostDisplay++;
                }

                if (lostHeadset == 2)
                {
                    

                    lostHeadset = 0;
                    totalSum += headsetPrice;

                }

                if (lostMouse == 3)
                {
                    lostMouse = 0;
                    totalSum += mousePrice;
                }
                if(lostDisplay == 2)
                {
                    lostDisplay = 0;
                    totalSum += displayPrice;
                }



            }
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}