namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());


            if (secondNumber > 10 )
            {
                Console.WriteLine($"{firstNumber} X {secondNumber} = {firstNumber*secondNumber}");
                return;
            }

            for (int i = secondNumber; i <= 10; i++)
            {
                Console.WriteLine($"{firstNumber} X {i} = {firstNumber*i}");
            }
        }
    }
}