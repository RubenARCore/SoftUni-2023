namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                List<int> shiftedList = new List<int>(input.Count);

                if (command[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", input));
                    Environment.Exit(0);
                }

                if (command[0] == "Add")
                {
                    input.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) > input.Count || int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine($"Invalid index");
                        continue;
                    }
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {

                    if (int.Parse(command[1]) > input.Count || int.Parse(command[1])<0)
                    {
                        Console.WriteLine($"Invalid index");
                        continue;
                    }

                    input.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Shift" && command[1] == "left")
                {
                    for (int j = 0; j < int.Parse(command[2]); j++)
                    {
                        int lastIndex = input[0];

                        for (int i = 0; i < input.Count-1; i++)
                        {
                            shiftedList.Add(input[i + 1]);
                        }
                        shiftedList.Add(lastIndex);

                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] = shiftedList[i];
                        }
                        shiftedList.Clear();

                    }
                }
                else if (command[0] == "Shift" && command[1] == "right")
                {
                    for (int j = 0; j < int.Parse(command[2]); j++)
                    {
                        int lastIndex = input[^1];
                        shiftedList.Add(lastIndex);
                        for (int i = 0; i < input.Count-1; i++)
                        {
                            shiftedList.Add(input[i]);
                        }

                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] = shiftedList[i];
                        }
                        shiftedList.Clear();
                    }
                }
            }
        }
    }
}