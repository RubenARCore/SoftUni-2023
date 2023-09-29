namespace _9._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (count == input)
                {
                    Console.WriteLine($"Sum: {sum}");
                    return;
                }

                if (i%2 !=0 )
                {
                    Console.WriteLine(i);
                    sum += i;
                    count++;
                }
            }
        }
    }
}