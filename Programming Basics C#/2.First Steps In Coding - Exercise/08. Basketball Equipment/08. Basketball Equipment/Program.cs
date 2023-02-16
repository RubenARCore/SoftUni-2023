namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());

            double sneakers = price - (price * 0.4);
            double drei = sneakers - (sneakers * 0.2);
            double ball = drei / 4;
            double accessories = ball / 5;

            Console.WriteLine(price + drei + sneakers + ball + accessories);
        }
    }
}