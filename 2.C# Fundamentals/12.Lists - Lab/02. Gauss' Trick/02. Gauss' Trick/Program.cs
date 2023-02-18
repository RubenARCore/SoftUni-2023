namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool isEven = input.Count % 2 == 0;

            List<int> result = new List<int>();

            for (int i = 1; i <= input.Count/2; i++)
            {
                result.Add(input[i-1] + input[input.Count-i]);
            }

            if (isEven)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                result.Add(input[(input.Count / 2)]);
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}