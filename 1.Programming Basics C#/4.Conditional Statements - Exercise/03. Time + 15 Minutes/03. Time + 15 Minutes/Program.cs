namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan hours = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan minutes = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));

            TimeSpan totalTime = hours + minutes.Add(TimeSpan.FromMinutes(15));

            Console.WriteLine($"{totalTime.Hours}:{totalTime.Minutes:00}");
        }
    }
}