using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper_ClassLibrary;



namespace Minesweeper_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            while (restart)
            {
                Console.Clear();
                //in parentheses write number of rows and columns you would like to create
                Board boardOne = new Board(8, 8);
                
                boardOne.createBombs();
                boardOne.setBombCounter();
                boardOne.printBoard();

                bool didWin = false;
                bool didLose = false;
                while (!(didWin || didLose))
                {
                    
                    Console.WriteLine("Pick row and column number to reveal a cell");
                    try
                    {
                        //read user input and subtract '1' for easier play (it is easier for player to count the rows and cols starting with one than zero)
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        boardOne.TheGrid[x, y].IsHidden = false;
                        boardOne.FloodFill(x, y);
                        Console.Clear();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Pick a number from 0 to {0} for rows \nPick a number from 1 to {1} for columns" , boardOne.Rows, boardOne.Columns);
                    }

                    //need to add recursion method for unrevealing similiar cells
                    
                    boardOne.printBoard();

                    //Win or lose check

                    if (boardOne.checkWin())
                        didWin = true;

                    if (boardOne.checkLoss())
                        didLose = true;
                    
                }
                Console.WriteLine("Game Over!! \n");
               Console.WriteLine("restart? y/n");
               string answer = Console.ReadLine();
                if (answer == "n")
                    restart = false;
            }
           

        }
    }
}
