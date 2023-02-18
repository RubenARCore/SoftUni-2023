namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string series = "Game of Thrones";
            //double durationS = 60;
            //double durationB = 96;

            string series = Console.ReadLine();
            double durationS = double.Parse(Console.ReadLine());
            double durationB = double.Parse(Console.ReadLine());

            double breackTime = durationB * 0.125;
            double seriesTime = durationB * 0.25;
            double totalTime = durationB - breackTime - seriesTime;

            if (totalTime >= durationS)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(totalTime - durationS)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(durationS - totalTime)} more minutes.");
            }
        }
    }
}