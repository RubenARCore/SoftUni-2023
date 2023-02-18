namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double budget = 15437.62;
            //double statists = 186;
            //double pricePP = 57.99;

            double budget = double.Parse(Console.ReadLine());
            double statists = double.Parse(Console.ReadLine());
            double pricePP = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double sumC = statists * pricePP;

            if (statists > 150)
            {
                sumC -= sumC * 0.1;
            }

            double totalBudget = decor + sumC;


            if (budget >= totalBudget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalBudget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalBudget - budget:f2} leva more.");
            }

        }
    }
}