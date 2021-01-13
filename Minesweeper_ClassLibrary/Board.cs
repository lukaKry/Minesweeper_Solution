﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper_ClassLibrary
{
    public class Board
    {
        

        //properties
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[,] TheGrid { get; set; }

        public string GameLevel { get; set; }

        Random rand = new Random();


        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            TheGrid = new Cell[Rows, Columns];
            GameLevel = "easy";

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    TheGrid[i, j] = new Cell();
                }
            }
        }

        public void printBoard()
        {
            for (int i = 0; i < Rows + Rows + 1; i++)
            {
                if (!(i % 2 == 0))
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        Console.Write("| ");
                        if (TheGrid[(i-1)/2, j].IsBomb == true)
                        {
                            Console.Write("*");
                        }
                        else
                        { 
                            Console.Write(" ");
                        }
                        Console.Write(" ");
                    }

                    Console.Write("|");
                    //Console.WriteLine("");

                }
                else
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        Console.Write("+---");


                    }
                    Console.Write("+");
                }
                Console.WriteLine("");

                
            }
        }


        public void createBombs()
        {
            float bombPercentage = 0.2f;
            
            switch (GameLevel)
            {
                case "easy": bombPercentage = 0.5f;
                    break;
                case "normal": bombPercentage = 0.2f;
                    break;
                case "hard":  bombPercentage = 0.3f;
                    break;
                default:
                    bombPercentage = 0.1f;
                    break;
            }

            for (int i = 0; i < Math.Round(bombPercentage * Rows * Columns); i++)
            {
                TheGrid[rand.Next(Rows), rand.Next(Columns)].IsBomb = true;
            }
        }

        public void setBombCounter()
        {
            for (int i = 0; i < Rows + Rows + 1; i++)
            {
                if (!(i % 2 == 0))
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        
                        if (TheGrid[(i - 1) / 2, j].IsBomb == true)
                        {

                            //Count bomb code snippet
                            if(isSafe(((i - 1) / 2) + 1, j + 1))
                                TheGrid[((i - 1) / 2) + 1, j + 1].BombCounter++;

                            if(isSafe(((i - 1) / 2) + 1, j + 0))
                                TheGrid[((i - 1) / 2) + 1, j + 0].BombCounter++;

                            if (isSafe(((i - 1) / 2) + 1, j - 1))
                                TheGrid[((i - 1) / 2) + 1, j - 1].BombCounter++;

                            if (isSafe(((i - 1) / 2) + 0, j + 1))
                                TheGrid[((i - 1) / 2) + 0, j + 1].BombCounter++;

                            if (isSafe(((i - 1) / 2) + 0, j - 1))
                                TheGrid[((i - 1) / 2) + 0, j - 1].BombCounter++;

                            if (isSafe(((i - 1) / 2) - 1, j + 1))
                                TheGrid[((i - 1) / 2) - 1, j + 1].BombCounter++;

                            if (isSafe(((i - 1) / 2) - 1, j - 1))
                                TheGrid[((i - 1) / 2) - 1, j - 1].BombCounter++;

                            if (isSafe(((i - 1) / 2) - 1, j + 0))
                                TheGrid[((i - 1) / 2) - 1, j + 0].BombCounter++;
                        }
                        
                    }

                }

            }


            for (int i = 0; i < Rows + Rows + 1; i++)
            {
                if (!(i % 2 == 0))
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        Console.Write("| ");
                        if (TheGrid[(i - 1) / 2, j].IsBomb == true)
                        {
                            Console.Write("*");
                            
                        }
                        else
                        {
                            if (TheGrid[(i - 1) / 2, j].BombCounter > 0)
                            {
                                Console.Write(TheGrid[(i - 1) / 2, j].BombCounter);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.Write(" ");
                    }

                    Console.Write("|");
                    

                }
                else
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        Console.Write("+---");


                    }
                    Console.Write("+");
                }
                Console.WriteLine("");


            }


        }

        private bool isSafe(int x, int y)
        {
            if(x >= 0 && x < Rows && y >= 0 && y < Columns)
                return true;
            return false;
        }

        
    }
}