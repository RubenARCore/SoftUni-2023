namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", input));
                    Environment.Exit(0);
                }

                if (command[0] == "Delete")
                {
                    input.RemoveAll(n => n == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }


            }
        }
    }
}