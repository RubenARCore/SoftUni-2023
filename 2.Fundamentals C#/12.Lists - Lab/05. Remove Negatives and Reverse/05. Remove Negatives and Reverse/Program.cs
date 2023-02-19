namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.RemoveAll(n => n < 0);

            input.Reverse();

            if (input.Count==0)
            {
                Console.WriteLine($"empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}