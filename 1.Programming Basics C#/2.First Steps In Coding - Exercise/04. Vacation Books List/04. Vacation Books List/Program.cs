namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPages = double.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double sum = totalPages / pagesPerHour / days;

            Console.WriteLine(Math.Floor(sum));
        }
    }
}