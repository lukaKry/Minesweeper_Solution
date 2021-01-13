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
                //in parenthesese write number of rows and columns you would like to create
                Board boardOne = new Board(4, 4);
                
                boardOne.createBombs();
                boardOne.setBombCounter();
                boardOne.printBoard();

                bool didWin = false;
                while (!didWin)
                {
                    
                    Console.WriteLine("Pick row and column number to reveal a cell");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    boardOne.TheGrid[x, y].IsHidden = false;
                    //need to add recursion method for unrevealing similiar cells

                    boardOne.printBoard();

                    //need to add didLose method - when player hits the bomb

                    if (boardOne.checkWin())
                        didWin = true;
                    
                }
                Console.WriteLine("Congrats!! \n");
               Console.WriteLine("restart? y/n");
               string answer = Console.ReadLine();
                if (answer == "n")
                    restart = false;
            }
           

        }
    }
}
