namespace _6._Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "England" || input == "USA")
            {
                Console.WriteLine("English");
            }
            else if (input == "Spain" || input == "Argentina" || input == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}