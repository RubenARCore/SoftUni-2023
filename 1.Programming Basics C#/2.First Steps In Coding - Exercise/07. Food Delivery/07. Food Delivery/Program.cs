namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine()) * 10.35;
            double fishMenu = double.Parse(Console.ReadLine()) * 12.40;
            double vegeMenu = double.Parse(Console.ReadLine()) * 8.15;

            double sum = chickenMenu + fishMenu + vegeMenu;
            double dessert = sum * 0.2;

            Console.WriteLine(sum + dessert + 2.5); ;
        }
    }
}