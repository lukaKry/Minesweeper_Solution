using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_WindowsFormsApp
{
    public partial class Form2 : Form
    {
        BindingSource bsEasy = new BindingSource();
        BindingSource bsNormal = new BindingSource();
        BindingSource bsHard = new BindingSource();

        public Form2()
        {
            InitializeComponent();
            //asings bindingsource to the results lists
            bsEasy.DataSource = ResultList.EasyLevel;
            bsNormal.DataSource = ResultList.NormalLevel;
            bsHard.DataSource = ResultList.HardLevel;

            //Reads Best scores file , easy level
            ResultList.EasyLevel.Clear();
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePathEasy = currentDirectory;
            filePathEasy += @"\BestScores_easy.txt";
            
            List<string> loadFileEasy = new List<string>();
            loadFileEasy = File.ReadAllLines(filePathEasy).ToList();
            foreach(string s in loadFileEasy)
            {
                string[] items = s.Split(',');
                Result one = new Result(items[0], int.Parse(items[1]));
                ResultList.EasyLevel.Add(one);
            }


            //Reads Best scores file, normal level
            ResultList.NormalLevel.Clear();
            string filePathNormal = currentDirectory;
            filePathNormal += @"\BestScores_normal.txt";

            List<string> loadFileNormal = new List<string>();
            loadFileNormal = File.ReadAllLines(filePathNormal).ToList();
            foreach (string s in loadFileNormal)
            {
                string[] items = s.Split(',');
                Result one = new Result(items[0], int.Parse(items[1]));
                ResultList.NormalLevel.Add(one);
            }


            //Reads Best scores file, hard level
            ResultList.HardLevel.Clear();
            string filePathHard = currentDirectory;
            filePathHard += @"\BestScores_hard.txt";

            List<string> loadFileHard = new List<string>();
            loadFileHard = File.ReadAllLines(filePathHard).ToList();
            foreach (string s in loadFileHard)
            {
                string[] items = s.Split(',');
                Result one = new Result(items[0], int.Parse(items[1]));
                ResultList.HardLevel.Add(one);
            }

            ResultList.EasyLevel.Sort();
            ResultList.NormalLevel.Sort();
            ResultList.HardLevel.Sort();

            //asigns data source for listboxes
            listBox1_easy.DataSource = bsEasy;
            listBox1_normal.DataSource = bsNormal;
            listBox2_hard.DataSource = bsHard;
        }
    }
}
