namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double number = double.Parse(Console.ReadLine());
                number *= number;
                Console.WriteLine($"{number:f3}");
            }
            else if (figure == "rectangle")
            {
                double number = double.Parse(Console.ReadLine());
                double number1 = double.Parse(Console.ReadLine());
                number = number * number1;
                Console.WriteLine($"{number:f3}");
            }
            else if (figure == "circle")
            {
                double number = double.Parse(Console.ReadLine());
                number = Math.PI * (number * number);
                Console.WriteLine($"{number:f3}");
            }
            else if (figure == "triangle")
            {
                double number = double.Parse(Console.ReadLine());
                double number1 = double.Parse(Console.ReadLine());
                number = number * number1 / 2;
                Console.WriteLine($"{number:f3}");
            }
        }
    }
}