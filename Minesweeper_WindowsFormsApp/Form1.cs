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
using System.Diagnostics;

namespace Minesweeper_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Button[,] buttonsGrid;
        private int rows, cols = 0;

        private Board boardOne;
        
        private int revealedCells;
        private int flagged;

        private Stopwatch watch = new Stopwatch();



        public Form1()
        {
            InitializeComponent();
            comboBox_LevelPicker.SelectedIndex = 0;

        }

        public void populateGrid()
        {
            panel_GridHolder.Controls.Clear();
            timer1.Enabled = true;
            watch.Reset();
            watch.Start();

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
                    
                    buttonsGrid[r, c].Width = 25;
                    buttonsGrid[r, c].Height = 25;

                    buttonsGrid[r, c].MouseUp += gridbutton_Click;
                    
                    panel_GridHolder.Controls.Add(buttonsGrid[r, c]);
                    buttonsGrid[r, c].Location = new Point(r * buttonsGrid[r, c].Width, c * buttonsGrid[r, c].Height);


                }
            }

            boardOne = new Board(rows, cols);
            boardOne.GameLevel = comboBox_LevelPicker.Text;
            boardOne.createBombs();
            boardOne.setBombCounter();
            assignColors();

            //update labels
            label_numOfBombs.Text = "Number of Bombs: " + boardOne.BombsNum.ToString();
            label_hiddenCells.Text = "Revealed Cells: " + revealedCells + " out of " + boardOne.TheGrid.Length;
            label_flags.Text = "Flags on the Minefield: " + flagged;

        }

        private void assignColors()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (boardOne.TheGrid[r, c].IsCounter == true)
                    {
                        buttonsGrid[r, c].Font = new Font(this.Font, FontStyle.Bold);
                        switch (boardOne.TheGrid[r,c].BombCounter)
                        {
                            case 0: buttonsGrid[r, c].ForeColor = Color.Black;
                                break;
                            case 1: buttonsGrid[r, c].ForeColor = Color.Blue;
                                break;
                            case 2: buttonsGrid[r, c].ForeColor = Color.Green;
                                break;
                            case 3: buttonsGrid[r, c].ForeColor = Color.Red;
                                break;
                            case 4: buttonsGrid[r, c].ForeColor = Color.DarkBlue;
                                break;
                            case 5: buttonsGrid[r, c].ForeColor = Color.DarkRed;
                                break;
                            default: buttonsGrid[r, c].ForeColor = Color.Pink;
                                break;
                        }
                    }
                }
            }
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
                {
                    drawBombs();
                    watch.Stop();
                    
                    ResultList.Score = (int)Math.Round(watch.Elapsed.TotalSeconds);
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    if (form3.DialogResult == DialogResult.OK)
                    {
                        Result rst = new Result(ResultList.Nick, ResultList.Score);

                        switch (comboBox_LevelPicker.Text)
                        {
                            case "easy":
                                ResultList.EasyLevel.Add(rst);
                                string currentDirectory = Directory.GetCurrentDirectory();
                                string filePathEasy = currentDirectory;
                                filePathEasy += @"\BestScores_easy.txt";
                                string[] saveResult = { $"{ResultList.Nick}, {ResultList.Score}" };
                                File.AppendAllText(filePathEasy, $"{ResultList.Nick}, {ResultList.Score}" + Environment.NewLine);
                                break;
                            case "normal":
                                ResultList.NormalLevel.Add(rst);
                                string currentDirectoryN = Directory.GetCurrentDirectory();
                                string filePathNormal = currentDirectoryN;
                                filePathNormal += @"\BestScores_normal.txt";
                                string[] saveResultN = { $"{ResultList.Nick}, {ResultList.Score}" };
                                File.AppendAllText(filePathNormal, $"{ResultList.Nick}, {ResultList.Score}" + Environment.NewLine);
                                break;
                            case "hard":
                                ResultList.HardLevel.Add(rst);
                                string currentDirectoryH = Directory.GetCurrentDirectory();
                                string filePathHard = currentDirectoryH;
                                filePathHard += @"\BestScores_hard.txt";
                                string[] saveResultH = { $"{ResultList.Nick}, {ResultList.Score}" };
                                File.AppendAllText(filePathHard, $"{ResultList.Nick}, {ResultList.Score}" + Environment.NewLine);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        MessageBox.Show("ups");


                    
                }

                if (boardOne.checkLoss())
                {
                    drawBombs();
                    watch.Stop();
                    MessageBox.Show("Game Over!");
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (btn.BackgroundImage == null && boardOne.TheGrid[x,y].IsHidden == true)
                {
                    flagged++;
                    btn.BackgroundImage = Minesweeper_WindowsFormsApp.Properties.Resources.pix_flag_red_512;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else
                {
                    flagged--;
                    btn.BackgroundImage = null;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                }



            }

           
            //updates labels
            label_hiddenCells.Text = "Revealed Cells: " + revealedCells + " out of " + boardOne.TheGrid.Length;
            label_flags.Text = "Flags on the Minefield: " + flagged;

        }

        private void drawBombs()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (boardOne.TheGrid[r, c].IsBomb == true)
                    {
                        boardOne.TheGrid[r, c].VisibleValue = "";
                        buttonsGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                        buttonsGrid[r, c].BackgroundImage = Properties.Resources.bomb_pixel;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            label_time.Text = elapsedTime;
        }

        private void button2_bestScores_Click(object sender, EventArgs e)
        {
            Form2 bestScores = new Form2();
            bestScores.Show();
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
                        if (boardOne.TheGrid[r,c].BombCounter == 0)
                        {
                            buttonsGrid[r, c].BackColor = Color.LightGray;
                        }
                        revealedCells++;
                    }
                }
            }
        }
    }
}
