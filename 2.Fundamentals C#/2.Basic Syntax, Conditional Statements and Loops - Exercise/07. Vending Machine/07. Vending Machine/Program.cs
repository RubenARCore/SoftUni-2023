using System;
using System.Net.WebSockets;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;

            while (true)
            {
                string inputCoin = Console.ReadLine();

                if (inputCoin == "Start")
                {
                    while (true)
                    {
                        string inputProduct = Console.ReadLine();

                        if(inputProduct == "End")
                        {
                            Console.WriteLine($"Change: {sum:f2}");
                            return;
                        }

                        if (inputProduct == "Nuts")
                        {
                            if (sum >= 2.0)
                            {
                                Console.WriteLine($"Purchased {inputProduct.ToLower()}");
                                sum -= 2;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else if (inputProduct == "Water")
                        {
                            if (sum >= 0.7)
                            {
                                Console.WriteLine($"Purchased {inputProduct.ToLower()}");
                                sum -= 0.7;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else if (inputProduct == "Crisps")
                        {
                            if (sum >= 1.5)
                            {
                                Console.WriteLine($"Purchased {inputProduct.ToLower()}");
                                sum -= 1.5;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                       else if (inputProduct == "Soda")
                        {
                            if (sum >= 0.8)
                            {
                                Console.WriteLine($"Purchased {inputProduct.ToLower()}");
                                sum -= 0.8;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else if (inputProduct == "Coke")
                        {
                            if (sum >= 1)
                            {
                                Console.WriteLine($"Purchased {inputProduct.ToLower()}");
                                sum -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid product");
                        }
                    }
                }

                double inputCoinPrice = double.Parse(inputCoin);

                if (inputCoinPrice == 0.1 || inputCoinPrice == 0.2 || inputCoinPrice ==  0.5 || inputCoinPrice== 1 || inputCoinPrice == 2)
                {
                    sum += inputCoinPrice;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputCoinPrice}");
                }
            }
        }
    }
}