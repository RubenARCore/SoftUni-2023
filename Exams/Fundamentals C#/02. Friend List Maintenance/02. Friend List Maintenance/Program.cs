namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] spearator = { ", "};
            List<string> inputNames = Console.ReadLine().Split(spearator, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> blacklisted = new List<string>();
            List<string> lost = new List<string>();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Report")
                {
                    int blacklistedCount = blacklisted.Count;
                    int lostCount = lost.Count;
                    Console.WriteLine($"Blacklisted names: {blacklistedCount}");
                    Console.WriteLine($"Lost names: {lostCount}");
                    Console.WriteLine(string.Join(" ", inputNames));
                    Environment.Exit(0);
                }

                if (command[0] == "Blacklist")
                {
                    if (inputNames.Contains(command[1]) == false)
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                        continue;
                    }

                    Console.WriteLine($"{command[1]} was blacklisted.");
                    blacklisted.Add(command[1]);
                    int index = inputNames.IndexOf(command[1]);
                    inputNames[index] = "Blacklisted";

                }
                else if (command[0] == "Error")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < inputNames.Count)
                    {
                        if (inputNames[int.Parse(command[1])] != "Blacklisted" && inputNames[int.Parse(command[1])] != "Lost")
                        {
                            Console.WriteLine($"{inputNames[int.Parse(command[1])]} was lost due to an error.");
                            inputNames[int.Parse(command[1])] = "Lost";
                            lost.Add(command[1]);
                        }
                    }
                }
                else if (command[0] == "Change")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < inputNames.Count)
                    {
                        Console.WriteLine($"{inputNames[int.Parse(command[1])]} changed his username to {command[2]}.");
                        inputNames[int.Parse(command[1])] = command[2];
                    }
                }

            }

        }
    }
}