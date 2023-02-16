namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double parcentage = double.Parse(Console.ReadLine()) / 100;

            //double length = 85;
            //double width = 75;
            //double height = 47;
            //double parcentage = 0.17;

            double sum = length * width * height / 1000;
            sum = sum - (sum * parcentage);

            Console.WriteLine(sum);
        }
    }
}