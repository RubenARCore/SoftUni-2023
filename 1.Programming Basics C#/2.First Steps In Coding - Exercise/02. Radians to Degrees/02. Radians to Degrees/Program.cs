namespace _02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine()) * 180 / Math.PI;

            Console.WriteLine(number);
        }
    }
}