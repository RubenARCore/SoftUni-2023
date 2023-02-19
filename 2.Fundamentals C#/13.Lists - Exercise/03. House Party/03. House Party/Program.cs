namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[2] == "not")
                {
                    if (names.Contains(input[0]))
                    {
                        names.Remove(input[0]);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(input[0] + " is not in the list!");
                        continue;
                    }
                }

                if (names.Contains(input[0]))
                {
                    Console.WriteLine(input[0]+" is already in the list!");
                    continue;
                }

                
                names.Add(input[0]);

            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}