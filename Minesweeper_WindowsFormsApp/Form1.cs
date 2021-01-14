using Minesweeper_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Button[,] buttonsGrid;
        private int rows, cols = 0;

        //private Cell[,] cellsGrid;

        private Board boardOne;
        


        public Form1()
        {
            InitializeComponent();
        }

        public void populateGrid()
        {
            panel_GridHolder.Controls.Clear();

            int x, y = 0;
            switch (comboBox_LevelPicker.Text)
            {
                case "easy": cols = rows = 5;
                    break;
                case "normal": cols = rows = 10;
                    break;
                case "hard": cols = rows = 15;
                    break;            
                default: cols = rows = 10;
                    break;
            }

            buttonsGrid = new Button[rows, cols];

            for (int r   = 0;  r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    buttonsGrid[r, c] = new Button();
                    
                    buttonsGrid[r, c].Width = 20;
                    buttonsGrid[r, c].Height = 20;

                    buttonsGrid[r, c].Click += gridbutton_Click;
                    
                    panel_GridHolder.Controls.Add(buttonsGrid[r, c]);
                    buttonsGrid[r, c].Location = new Point(r * buttonsGrid[r, c].Width, c * buttonsGrid[r, c].Height);


                }
            }

            boardOne = new Board(rows, cols);
            boardOne.createBombs();
            boardOne.setBombCounter();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateGrid();

        }

        private void gridbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point p = btn.Location;
            int x = p.X / btn.Width;
            int y = p.Y / btn.Height;

            boardOne.TheGrid[x, y].revealCell();
            boardOne.TheGrid[x, y].setVisibleValue();
            btn.Text = boardOne.TheGrid[x, y].VisibleValue;


            if (boardOne.TheGrid[x, y].BombCounter == 0)
            {
                boardOne.FloodFill(x, y);
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (boardOne.TheGrid[r, c].IsHidden == false)
                    {
                        boardOne.TheGrid[r, c].setVisibleValue();
                        buttonsGrid[r, c].Text = boardOne.TheGrid[r, c].VisibleValue;
                    }
                }
            }
        

            if (boardOne.checkWin())
                MessageBox.Show("Congrats!");

            if (boardOne.checkLoss())
                MessageBox.Show("Game Over!");


        }
    }
}
