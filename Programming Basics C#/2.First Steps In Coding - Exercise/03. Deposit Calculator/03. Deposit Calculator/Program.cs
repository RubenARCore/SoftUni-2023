namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double manths = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            double sum = deposit * percent / 12;
            sum = deposit + manths * sum;

            Console.WriteLine(sum);
        }
    }
}