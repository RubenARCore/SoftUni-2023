namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number = 175;
            double number = double.Parse(Console.ReadLine());
            double bonus = 0;

            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number % 5 == 0)
            {
                bonus += 2;
            }

            if (number <= 100)
            {
                bonus += 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonus += number * 0.2;
            }
            else
            {
                bonus += number * 0.1;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}