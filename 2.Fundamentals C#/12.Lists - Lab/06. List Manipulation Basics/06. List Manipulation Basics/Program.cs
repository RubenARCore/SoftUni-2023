namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", inputList));
                    return;
                }


                if (command[0] == "Add")
                {
                    inputList.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    inputList.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    inputList.RemoveAt(int.Parse(command[1]));

                }
                else if (command[0] == "Insert")
                {
                    inputList.Insert(int.Parse(command[2]), int.Parse(command[1]));

                }


            }
        }
    }
}