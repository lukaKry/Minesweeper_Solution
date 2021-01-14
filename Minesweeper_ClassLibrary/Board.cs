using System;
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

        public double BombsNum { get; set; }

        Random rand = new Random();


        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            TheGrid = new Cell[Rows, Columns];
            GameLevel = "easy";
            BombsNum = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    TheGrid[i, j] = new Cell();
                }
            }
        }

        

        public bool checkWin()
        {
            int revealedCellCount = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (TheGrid[i,j].IsHidden == false)
                    {
                        revealedCellCount++;
                    }
                }
            }
            
            return (revealedCellCount == TheGrid.Length - BombsNum);               
        }

        public void FloodFill(int x, int y)
        {
                TheGrid[x, y].IsHidden = false;


            if (isValid(x - 1, y) && TheGrid[x-1,y].BombCounter > 0)
                TheGrid[x - 1, y].IsHidden = false;

            if (isValid(x + 1, y) && TheGrid[x + 1, y].BombCounter > 0)
                TheGrid[x + 1, y].IsHidden = false;

            if (isValid(x, y + 1) && TheGrid[x , y+1].BombCounter > 0)
                TheGrid[x, y + 1].IsHidden = false;

            if (isValid(x, y - 1) && TheGrid[x, y-1].BombCounter > 0)
                TheGrid[x, y - 1].IsHidden = false;





            if (isValid(x + 1, y))
                if (TheGrid[x + 1, y].IsHidden == true)
                    FloodFill(x + 1, y);
               

            if (isValid(x, y + 1))
                if (TheGrid[x, y + 1].IsHidden == true)
                    FloodFill(x, y + 1);

                if (isValid(x - 1, y))
                    if (TheGrid[x - 1, y].IsHidden == true)
                        FloodFill(x - 1, y);

                if (isValid(x , y - 1))
                    if (TheGrid[x, y - 1].IsHidden == true)
                        FloodFill(x, y - 1);

        }

        private bool isValid(int x, int y)
        {
            return (x >= 0 && x < Rows && y >= 0 && y < Columns && TheGrid[x,y].BombCounter == 0);
        }

        public void printBoard()
        {
            for (int i = 0; i < Rows; i++)
            {
                    for (int j = 0; j < Columns; j++)
                    {
                        
                        if (TheGrid[i, j].IsHidden == false)
                        {
                        TheGrid[i, j].setVisibleValue();
                            Console.Write(TheGrid[i,j].VisibleValue);
                        }
                        else
                        {
                            Console.Write(" ? ");
                        }
                        
                    }
                    Console.WriteLine("");
            }
        }

        public bool checkLoss()
        {
            bool loose = false;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (TheGrid[i, j].IsHidden == false && TheGrid[i, j].IsBomb == true)
                        loose = true;
                }
            }
            return loose;
        }

        public void createBombs()
        {
            float bombPercentage = 0.2f;
            
            switch (GameLevel)
            {
                case "easy": bombPercentage = 0.1f;
                    break;
                case "normal": bombPercentage = 0.2f;
                    break;
                case "hard":  bombPercentage = 0.3f;
                    break;
                default:
                    bombPercentage = 0.1f;
                    break;
            }

            BombsNum = Math.Round(bombPercentage * Rows * Columns);

            for (int i = 0; i < BombsNum; i++)
            {
                int a = rand.Next(Rows);
                int b = rand.Next(Columns);
                TheGrid[a, b].IsBomb = true;
                TheGrid[a, b].IsCounter = false;

            }
        }

        public void setBombCounter()
        {
            for (int i = 0; i < Rows; i++)
            {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (TheGrid[i, j].IsBomb == true)
                        {

                            //Count bomb code snippet
                            if(isSafe(i + 1, j + 1))
                                TheGrid[i + 1, j + 1].BombCounter++;

                            if(isSafe(i + 1, j + 0))
                                TheGrid[i + 1, j + 0].BombCounter++;

                            if (isSafe(i + 1, j - 1))
                                TheGrid[i + 1, j - 1].BombCounter++;

                            if (isSafe(i + 0, j + 1))
                                TheGrid[i + 0, j + 1].BombCounter++;

                            if (isSafe(i + 0, j - 1))
                                TheGrid[i + 0, j - 1].BombCounter++;

                            if (isSafe(i - 1, j + 1))
                                TheGrid[i - 1, j + 1].BombCounter++;

                            if (isSafe(i - 1, j - 1))
                                TheGrid[i - 1, j - 1].BombCounter++;

                            if (isSafe(i - 1, j + 0))
                                TheGrid[i - 1, j + 0].BombCounter++;
                        }
                        
                    }
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
