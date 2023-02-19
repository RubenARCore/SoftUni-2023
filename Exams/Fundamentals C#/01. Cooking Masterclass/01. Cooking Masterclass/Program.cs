namespace _01._Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            double extraApron = students * 0.2;
            extraApron = Math.Ceiling(extraApron);

            double totalApron = priceApron * (students + extraApron);

            double totalEggs = singleEggPrice * 10 * students;

            double freeFlour = students / 5;
            double totalFlourPrice = priceFlour * (students - freeFlour);

            double totalSum = totalApron + totalEggs + totalFlourPrice;


            if (budget - totalSum >= 0)
            {
                Console.WriteLine($"Items purchased for {totalSum:f2}$.");
            }
            else
            {
                Console.WriteLine($"{totalSum - budget:f2}$ more needed.");
            }
        }
    }
}