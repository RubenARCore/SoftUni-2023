namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string password = "s3cr3t!P@ssw0rd";

            if (password == input)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}