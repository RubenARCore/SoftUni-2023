using System;
 
namespace Login
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int counter = 0;
            char[] passwordChar = username.ToCharArray();
            Array.Reverse(passwordChar);
 
            string password = new string(passwordChar);
            while(true)
            {
                if (Console.ReadLine() == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
            }
 
        }
    }
}