namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstTime = TimeSpan.FromSeconds(double.Parse(Console.ReadLine()));
            var secondTime = TimeSpan.FromSeconds(double.Parse(Console.ReadLine()));
            var thirdTime = TimeSpan.FromSeconds(double.Parse(Console.ReadLine()));

            TimeSpan totalMinutes = firstTime + secondTime + thirdTime;

            Console.WriteLine($"{totalMinutes.Minutes}:{totalMinutes.Seconds:00}");
        }
    }
}