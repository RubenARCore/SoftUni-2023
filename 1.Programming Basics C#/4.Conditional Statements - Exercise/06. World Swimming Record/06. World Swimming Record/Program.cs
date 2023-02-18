namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double seconds = 55555.67;
            //double meters = 3017;
            //double secondsPerM = 5.03;

            double seconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerM = double.Parse(Console.ReadLine());

            double totalTrip = meters * secondsPerM;
            double resistance = Math.Floor(meters / 15) * 12.5;

            double totalTime = totalTrip + resistance;

            if (totalTime < seconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - seconds:f2} seconds slower.");
            }
        }
    }
}