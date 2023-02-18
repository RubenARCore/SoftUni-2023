namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nailon = double.Parse(Console.ReadLine()) + 2;
            nailon = nailon * 1.5;
            double paint = double.Parse(Console.ReadLine());
            paint = paint + (paint * 0.1);
            paint = paint * 14.50;

            double razredtel = double.Parse(Console.ReadLine()) * 5;
            double hours = double.Parse(Console.ReadLine());

            double sum = nailon + paint + razredtel + 0.40;

            double salary = (sum * 0.3) * hours;

            Console.WriteLine(sum + salary);
        }
    }
}