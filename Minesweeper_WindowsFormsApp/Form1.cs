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
using System.IO;
using System.Reflection;

namespace Minesweeper_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Button[,] buttonsGrid;
        private int rows, cols = 0;

        private Board boardOne;
        
        private int revealedCells;
        private int flagged;
        


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

                    buttonsGrid[r, c].MouseUp += gridbutton_Click;
                    
                    panel_GridHolder.Controls.Add(buttonsGrid[r, c]);
                    buttonsGrid[r, c].Location = new Point(r * buttonsGrid[r, c].Width, c * buttonsGrid[r, c].Height);


                }
            }

            boardOne = new Board(rows, cols);
            boardOne.GameLevel = comboBox_LevelPicker.Text;
            boardOne.createBombs();
            boardOne.setBombCounter();

            //update labels
            label_numOfBombs.Text = "Number of bombs: " + boardOne.BombsNum.ToString();
            label_hiddenCells.Text = "Revealed Cells: " + revealedCells + " out of " + boardOne.TheGrid.Length;
            label_flags.Text = "Flags on the minefiels: " + flagged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            revealedCells = 0;
            flagged = 0;
            populateGrid();

        }

        private void gridbutton_Click(object sender, MouseEventArgs e)
        {
           
            Button btn = (Button)sender;
            Point p = btn.Location;
            int x = p.X / btn.Width;
            int y = p.Y / btn.Height;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                if (btn.BackgroundImageLayout == System.Windows.Forms.ImageLayout.Stretch)
                {
                    flagged--;
                    btn.BackgroundImage = null;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                }
                

                boardOne.TheGrid[x, y].revealCell();
                boardOne.TheGrid[x, y].setVisibleValue();
                btn.Text = boardOne.TheGrid[x, y].VisibleValue;


                if (boardOne.TheGrid[x, y].BombCounter == 0)
                {
                    boardOne.FloodFill(x, y);
                }


                countRevealedCells();
       

                if (boardOne.checkWin())
                    MessageBox.Show("Congrats!");

                if (boardOne.checkLoss())
                    MessageBox.Show("Game Over!");
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (btn.BackgroundImage == null && boardOne.TheGrid[x,y].IsHidden == true)
                {
                    flagged++;
                    btn.BackgroundImage = Minesweeper_WindowsFormsApp.Properties.Resources.pix_flag_red_512;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }

            }

           
            //updates labels
            label_hiddenCells.Text = "Revealed Cells: " + revealedCells + " out of " + boardOne.TheGrid.Length;
            label_flags.Text = "Flags on the minefiels: " + flagged;

        }

        private void countRevealedCells()
        {
            revealedCells = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (boardOne.TheGrid[r, c].IsHidden == false)
                    {
                        boardOne.TheGrid[r, c].setVisibleValue();
                        buttonsGrid[r, c].Text = boardOne.TheGrid[r, c].VisibleValue;
                        revealedCells++;
                    }
                }
            }
        }
    }
}
