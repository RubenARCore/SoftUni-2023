namespace _03._Deck_of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { ", " };
            List<string> inputCards = Console.ReadLine().Split(separator, StringSplitOptions.None).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(separator, StringSplitOptions.None).ToList();

                if (command[0] == "Add")
                {
                    if (inputCards.Contains(command[1]))
                    {
                        Console.WriteLine($"Card is already in the deck");
                    }
                    else
                    {
                        Console.WriteLine($"Card successfully added");
                        inputCards.Add(command[1]);
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (inputCards.Contains(command[1]) == false)
                    {
                        Console.WriteLine($"Card not found");
                    }
                    else
                    {
                        Console.WriteLine($"Card successfully removed");
                        inputCards.Remove(command[1]);
                    }
                }
                else if (command[0] == "Remove At")
                {
                    if ((int.Parse(command[1]) >= 0 && int.Parse(command[1]) < inputCards.Count) == false)
                    {
                        Console.WriteLine($"Index out of range");
                    }
                    else
                    {
                        inputCards.RemoveAt(int.Parse(command[1]));
                        Console.WriteLine($"Card successfully removed");
                    }
                }
                else if (command[0] == "Insert")
                {
                    if ((int.Parse(command[1]) >= 0 && int.Parse(command[1]) < inputCards.Count) == false)
                    {
                        Console.WriteLine($"Index out of range");
                        continue;
                    }
                    if ((int.Parse(command[1]) >= 0 && int.Parse(command[1]) < inputCards.Count))
                    {
                        if (inputCards.Contains(command[2]))
                        {
                            Console.WriteLine($"Card is already added");
                        }
                        else
                        {
                            Console.WriteLine($"Card successfully added");
                            inputCards.Insert(int.Parse(command[1]), command[2]);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", inputCards));

        }
    }
}