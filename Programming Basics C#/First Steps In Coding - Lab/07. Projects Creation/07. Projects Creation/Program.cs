namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int sum = projects * 3;

            Console.WriteLine($"The architect {name} will need {sum} hours to complete {projects} project/s.");
        }
    }
}