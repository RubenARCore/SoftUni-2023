namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFood = double.Parse(Console.ReadLine()) * 2.50;
            double catFood = double.Parse(Console.ReadLine()) * 4;

            Console.WriteLine($"{dogFood + catFood} lv.");
        }
    }
}