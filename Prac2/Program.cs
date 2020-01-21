using System;
using System.Collections.Generic;

namespace Prac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[][] puzzle =
            {
                new string[] {"1", "2", "3"},
                new string[] {"4", "5", "6"},
                new string[] {"7", "8", "X"},

            };
            
            bool flag = true;
            
            while(flag == true)
            {
            Console.WriteLine("Enter Move: ");
            string move = Console.ReadLine();

                if (move == "exit")
                {
                    flag = false;
                }
                if (move == "1")
                {
                    MoveUp(puzzle);
                    PrintPuzzle(puzzle);
                }

                if (move == "2")
                {
                    MoveDown(puzzle);
                    PrintPuzzle(puzzle);
                }

                if (move == "3")
                {
                    MoveLeft(puzzle);
                    PrintPuzzle(puzzle);
                }

                if (move == "4")
                {
                    MoveRight(puzzle);
                    PrintPuzzle(puzzle);
                }
            }
        }

        static void PrintPuzzle(string[][] puzzle)
        {
            for (int n = 0; n < puzzle.Length; n++)
            {
                for (int k = 0; k < puzzle[n].Length; k++)
                {
                        Console.WriteLine(puzzle[n][k]);
                }
            }
        }

        public static string[][] MoveUp(string[][] puzzle)
        {
            List<int> xPos = new List<int>();
            
            for (int n = 0; n < puzzle.Length; n++)
            {
                for (int k = 0; k < puzzle[n].Length; k++)
                {
                    if (puzzle[n][k] == "X")
                    {
                        xPos.Add(n);
                        xPos.Add(k);
                        break;
                    }
                }
            }
            
            int xRow = xPos[0];
            int xCol = xPos[1];

            if (xRow > 0)
            {
                string temp = puzzle[xRow][xCol];
                puzzle[xRow][xCol] = puzzle[xRow-1][xCol];
                puzzle[xRow - 1][xCol] = temp;
            }
            else
            {
                Console.WriteLine("Outside Board");
            }

            return puzzle;

        }

        public static string[][] MoveDown(string[][] puzzle)
        {
            List<int> xPos = new List<int>();
            
            for (int n = 0; n < puzzle.Length; n++)
            {
                for (int k = 0; k < puzzle[n].Length; k++)
                {
                    if (puzzle[n][k] == "X")
                    {
                        xPos.Add(n);
                        xPos.Add(k);
                        break;
                    }
                }
            }
            
            int xRow = xPos[0];
            int xCol = xPos[1];

            if (xRow > 0)
            {
                string temp = puzzle[xRow][xCol];
                puzzle[xRow][xCol] = puzzle[xRow+1][xCol];
                puzzle[xRow + 1][xCol] = temp;
            }
            else
            {
                Console.WriteLine("Outside Board");
            }

            return puzzle;

        }

        public static string[][] MoveRight(string[][] puzzle)
        {
            List<int> xPos = new List<int>();
            
            for (int n = 0; n < puzzle.Length; n++)
            {
                for (int k = 0; k < puzzle[n].Length; k++)
                {
                    if (puzzle[n][k] == "X")
                    {
                        xPos.Add(n);
                        xPos.Add(k);
                        break;
                    }
                }
            }
            
            int xRow = xPos[0];
            int xCol = xPos[1];

            if (xRow > 0)
            {
                string temp = puzzle[xRow][xCol];
                puzzle[xRow][xCol] = puzzle[xRow][xCol+1];
                puzzle[xRow][xCol+1] = temp;
            }
            else
            {
                Console.WriteLine("Outside Board");
            }

            return puzzle;

        }

        public static string[][] MoveLeft(string[][] puzzle)
        {
            List<int> xPos = new List<int>();
            
            for (int n = 0; n < puzzle.Length; n++)
            {
                for (int k = 0; k < puzzle[n].Length; k++)
                {
                    if (puzzle[n][k] == "X")
                    {
                        xPos.Add(n);
                        xPos.Add(k);
                        break;
                    }
                }
            }
            
            int xRow = xPos[0];
            int xCol = xPos[1];

            if (xRow > 0)
            {
                string temp = puzzle[xRow][xCol];
                puzzle[xRow][xCol] = puzzle[xRow][xCol-1];
                puzzle[xRow][xCol-1] = temp;
            }
            else
            {
                Console.WriteLine("Outside Board");
            }

            return puzzle;

        }
    }
}