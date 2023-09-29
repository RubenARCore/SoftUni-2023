namespace _4._Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan hours = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan minutes = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));

            TimeSpan totalTime = hours + minutes + TimeSpan.FromMinutes(30);

            Console.WriteLine($"{totalTime.Hours:d1}:{totalTime.Minutes:d2}");
        }
    }
}