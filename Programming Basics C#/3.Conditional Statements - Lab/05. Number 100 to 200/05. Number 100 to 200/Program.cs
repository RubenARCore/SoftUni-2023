namespace _05._Number_100_to_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (input < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (input >= 100 & input <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}