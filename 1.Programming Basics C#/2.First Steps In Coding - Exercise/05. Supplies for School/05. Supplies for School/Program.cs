namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pensils = double.Parse(Console.ReadLine()) * 5.8;
            double markers = double.Parse(Console.ReadLine()) * 7.2;
            double litres = double.Parse(Console.ReadLine()) * 1.2;
            double percent = double.Parse(Console.ReadLine()) / 100;

            double sum = pensils + markers + litres;

            sum = sum - (sum * percent);



            Console.WriteLine(sum);
        }
    }
}