namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double excursion = 40.8;
            //double puzzles = 20;
            //double annabells = 25;
            //double tedBears = 30;
            //double minions = 50;
            //double trucks = 10;

            double puzzlesp = 2.6;
            double annabellsp = 3.0;
            double tedBearsp = 4.10;
            double minionsp = 8.20;
            double trucksp = 2;

            double excursion = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());
            double annabells = double.Parse(Console.ReadLine());
            double tedBears = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());

            double count = puzzles + annabells + tedBears + minions + trucks;
            double totalSum = puzzles * puzzlesp + annabells * annabellsp + tedBears * tedBearsp + minions * minionsp + trucks * trucksp;

            if (count >= 50)
            {
                totalSum -= totalSum * 0.25;
                totalSum -= totalSum * 0.1;
            }
            else
            {
                totalSum -= totalSum * 0.1;
            }

            if (totalSum >= excursion)
            {
                Console.WriteLine($"Yes! {totalSum - excursion:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursion - totalSum:f2} lv needed.");
            }
        }
    }
}