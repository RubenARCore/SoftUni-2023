namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool checkForChanges = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    if (checkForChanges)
                    {
                        Console.WriteLine(string.Join(" ",inputList));
                    }
                    return;
                }


                if (command[0] == "Add")
                {
                    inputList.Add(int.Parse(command[1]));
                    checkForChanges = true;
                }
                else if (command[0] == "Remove")
                {
                    inputList.Remove(int.Parse(command[1]));
                    checkForChanges = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    inputList.RemoveAt(int.Parse(command[1]));
                    checkForChanges = true;

                }
                else if (command[0] == "Insert")
                {
                    inputList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    checkForChanges = true;

                }
                else if (command[0] == "Contains")
                {
                    bool checkContains = inputList.Contains(int.Parse(command[1]));

                    if (checkContains)
                    {
                        Console.WriteLine($"Yes");
                    }
                    else
                    {
                        Console.WriteLine($"No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    List<int> result = new List<int>();
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] % 2 ==0)
                        {
                            result.Add(inputList[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ",result));
                }
                else if (command[0] == "PrintOdd")
                {
                    List<int> result = new List<int>();
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] % 2 != 0)
                        {
                            result.Add(inputList[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", result));
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(inputList.Sum());
                }
                else if (command[0] == "Filter")
                {
                    
                    if (command[1] == "<")
                    {
                        List<int> filterResult = new List<int>(inputList.FindAll(n=> n < int.Parse(command[2])));
                        Console.WriteLine(string.Join(" ", filterResult));
                    }
                    else if (command[1] == ">")
                    {
                        List<int> filterResult = new List<int>(inputList.FindAll(n => n > int.Parse(command[2])));
                        Console.WriteLine(string.Join(" ", filterResult));
                    }
                    else if (command[1] == ">=")
                    {
                        List<int> filterResult = new List<int>(inputList.FindAll(n => n >= int.Parse(command[2])));
                        Console.WriteLine(string.Join(" ", filterResult));
                    }
                    else if (command[1] == "<=")
                    {
                        List<int> filterResult = new List<int>(inputList.FindAll(n => n <= int.Parse(command[2])));
                        Console.WriteLine(string.Join(" ", filterResult));
                    }
                }


            }
        }
    }
}