﻿using System;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] field = new int[int.Parse(Console.ReadLine())];
            int[] marker = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var index in marker)
            {
                if (index < 0 || index > field.Length - 1)
                {
                    continue;
                }
                field[index] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] instructions = command.Split();
                int start = int.Parse(instructions[0]);
                int fly = int.Parse(instructions[2]);

                if (start < 0 || start >= field.Length || field[start] != 1)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (instructions[1] == "right")
                {
                    field[start] = 0;
                    int newIndex = start + fly;
                    while (newIndex < field.Length)
                    {
                        if (field[newIndex] == 1)
                        {
                            newIndex += fly;
                            continue;
                        }
                        field[newIndex] = 1;
                        break;
                    }
                }
                else if (instructions[1] == "left")
                {
                    field[start] = 0;
                    int newIndex = start - fly;
                    while (newIndex >= 0)
                    {
                        if (field[newIndex] == 1)
                        {
                            newIndex -= fly;
                            continue;
                        }
                        field[newIndex] = 1;
                        break;
                    }
                }
                command = Console.ReadLine();
            }

            foreach (int item in field)
            {
                Console.Write($"{item} ");
            }

        }
    }
}