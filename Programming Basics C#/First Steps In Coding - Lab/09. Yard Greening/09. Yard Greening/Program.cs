namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double land = double.Parse(Console.ReadLine()) * 7.61;

            double discount = 0.18 * land;
            double sum = land - discount;

            Console.WriteLine($"The final price is: {sum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}