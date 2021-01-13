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
                Board boardOne = new Board(8, 8);
                
                boardOne.createBombs();
                boardOne.setBombCounter();

                boardOne.hideThemAll();

                boardOne.printBoard();
                Console.WriteLine("restart? y/n");
                string answer = Console.ReadLine();
                if (answer == "n")
                    restart = false;
            }
           

        }
    }
}
