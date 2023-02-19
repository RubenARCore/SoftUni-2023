namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int countOfBigger = Math.Max(firstInput.Count,secondInput.Count);
            int difference = 0;

            for (int i = 1; i <= countOfBigger; i++)
            {
                if (i > Math.Min(firstInput.Count,secondInput.Count))
                {
                    break;
                }

                if (i % 2 != 0)
                {
                    result.Add(firstInput[i-1]);
                    result.Add(secondInput[i-1]);

                }
                else
                {
                    result.Add(firstInput[i - 1]);
                    result.Add(secondInput[i - 1]);
                }
            }

            if (firstInput.Count > secondInput.Count)
            {
                difference = firstInput.Count - secondInput.Count;
                for (int i = difference; i > 0; i--)
                {
                    result.Add(firstInput[firstInput.Count-i]);
                }

                Console.WriteLine(string.Join(" ", result));
            }
            else if (secondInput.Count > firstInput.Count)
            {
                difference = secondInput.Count - firstInput.Count;

                for (int i = difference; i > 0; i--)
                {
                    result.Add(secondInput[secondInput.Count-i]);
                }

                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
                Environment.Exit(0);
            }

            
            

        }
    }
}