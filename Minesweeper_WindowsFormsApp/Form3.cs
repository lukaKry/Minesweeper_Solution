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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1_score.Text = ResultList.Score.ToString();
            button1_submit.DialogResult = DialogResult.OK;
        }

        private void button1_submit_Click(object sender, EventArgs e)
        {
            ResultList.Nick = textBox1_nick.Text;
            
            this.Close();
        }
    }
}
