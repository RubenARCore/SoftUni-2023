using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 0;

                string input = Console.ReadLine();

                char[] charInput = input.ToCharArray();


                for (int j = 0; j < input.Length; j++)
                {
                    if (charInput[j] == 'a' || charInput[j] == 'e'
                                            || charInput[j] == 'i'
                                            || charInput[j] == 'o'
                                            || charInput[j] == 'u'
                                            || charInput[j] == 'A'
                                            || charInput[j] == 'E'
                                            || charInput[j] == 'I'
                                            || charInput[j] == 'O'
                                            || charInput[j] == 'U')
                    {
                        sum += charInput[j] * input.Length;
                    }
                    else
                    {
                        sum += charInput[j] / input.Length;
                    }
                }
                result[i] = sum;
            }
            Array.Sort(result);

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(result[j]);
            }

        }
    }
}