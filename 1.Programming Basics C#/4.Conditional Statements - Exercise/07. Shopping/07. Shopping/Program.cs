namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videocards = double.Parse(Console.ReadLine());
            double processors = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());

            double vPrice = videocards * 250;
            double pPrice = processors * vPrice * 0.35;
            double rPrice = ram * vPrice * 0.10;

            double totalSum = vPrice + pPrice + rPrice;

            if (videocards >= processors)
            {
                totalSum -= totalSum * 0.15;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:f2} leva more!");
            }
        }
    }
}