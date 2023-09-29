namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int division = 0;

            if (input % 2 == 0)
            {
                division = 2;
            }
            if (input % 3 == 0)
            {
                division = 3;
            }
            if (input % 6 == 0)
            {
                division = 6;
            }
            if (input % 7 == 0)
            {
                division = 7;
            }
            if (input % 10 == 0)
            {
                division = 10;
            }
            
            if(division == 0) 
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {division}");
            }

            
        }
    }
}