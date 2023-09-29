namespace _05._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
                
            if (month > 12 || month < 1)
            {
                Console.WriteLine("Error!");
                return;
            }
            DateTime inpout = new DateTime(2023, month, 1);

            Console.WriteLine(inpout.ToString("MMMM"));
        }
    }
}