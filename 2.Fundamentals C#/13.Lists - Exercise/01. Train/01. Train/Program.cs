namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    Console.WriteLine(string.Join(" ",wagons));
                    return;
                }

                List<string> command = new List<string>(input.Split());

                if (command.Count == 1)
                {
                    var passengers = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                    wagons.Add(int.Parse(command[1]));
                }
            }
        }
    }
}