namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            input *= 1.31;

            Console.WriteLine($"{input:f3}");
        }
    }
}