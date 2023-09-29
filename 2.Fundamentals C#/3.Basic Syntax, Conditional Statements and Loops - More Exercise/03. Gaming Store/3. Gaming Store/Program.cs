using System;

namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double remaining = balance;

            while (true)                
            {
                string input = Console.ReadLine();

                if (input == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${remaining - balance:f2}. Remaining: ${balance:f2} ");
                    return;
                }

                if (input == "OutFall 4")
                {
                    if (balance - 39.99 >= 0)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 39.99;
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "CS: OG")
                {
                    if (balance - 15.99 >= 0)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 15.99;
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (balance - 19.99 >= 0)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 19.99;
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Honored 2")
                {
                    if (balance - 59.99 >= 0)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 59.99;
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (balance - 29.99 >= 0)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 29.99;
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance - 39.99 >= 0)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 39.99;
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }


            }
        }
    }
}