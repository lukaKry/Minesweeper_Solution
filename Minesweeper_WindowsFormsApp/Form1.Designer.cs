
namespace Minesweeper_WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_GridHolder = new System.Windows.Forms.Panel();
            this.comboBox_LevelPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_numOfBombs = new System.Windows.Forms.Label();
            this.label_hiddenCells = new System.Windows.Forms.Label();
            this.label_flags = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.button2_bestScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_GridHolder
            // 
            this.panel_GridHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_GridHolder.Location = new System.Drawing.Point(21, 32);
            this.panel_GridHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_GridHolder.Name = "panel_GridHolder";
            this.panel_GridHolder.Size = new System.Drawing.Size(501, 462);
            this.panel_GridHolder.TabIndex = 0;
            // 
            // comboBox_LevelPicker
            // 
            this.comboBox_LevelPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LevelPicker.FormattingEnabled = true;
            this.comboBox_LevelPicker.Items.AddRange(new object[] {
            "easy",
            "normal",
            "hard"});
            this.comboBox_LevelPicker.Location = new System.Drawing.Point(637, 28);
            this.comboBox_LevelPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_LevelPicker.Name = "comboBox_LevelPicker";
            this.comboBox_LevelPicker.Size = new System.Drawing.Size(161, 24);
            this.comboBox_LevelPicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Draw Board";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_numOfBombs
            // 
            this.label_numOfBombs.AutoSize = true;
            this.label_numOfBombs.Location = new System.Drawing.Point(553, 401);
            this.label_numOfBombs.Name = "label_numOfBombs";
            this.label_numOfBombs.Size = new System.Drawing.Size(125, 17);
            this.label_numOfBombs.TabIndex = 4;
            this.label_numOfBombs.Text = "Number of Bombs:";
            // 
            // label_hiddenCells
            // 
            this.label_hiddenCells.AutoSize = true;
            this.label_hiddenCells.Location = new System.Drawing.Point(553, 438);
            this.label_hiddenCells.Name = "label_hiddenCells";
            this.label_hiddenCells.Size = new System.Drawing.Size(106, 17);
            this.label_hiddenCells.TabIndex = 5;
            this.label_hiddenCells.Text = "Revealed Cells:";
            // 
            // label_flags
            // 
            this.label_flags.AutoSize = true;
            this.label_flags.Location = new System.Drawing.Point(553, 475);
            this.label_flags.Name = "label_flags";
            this.label_flags.Size = new System.Drawing.Size(150, 17);
            this.label_flags.TabIndex = 6;
            this.label_flags.Text = "Flags on the Minefield:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_time.Location = new System.Drawing.Point(26, 6);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(55, 24);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "00:00";
            // 
            // button2_bestScores
            // 
            this.button2_bestScores.Location = new System.Drawing.Point(697, 355);
            this.button2_bestScores.Name = "button2_bestScores";
            this.button2_bestScores.Size = new System.Drawing.Size(122, 29);
            this.button2_bestScores.TabIndex = 8;
            this.button2_bestScores.Text = "Best Scores";
            this.button2_bestScores.UseVisualStyleBackColor = true;
            this.button2_bestScores.Click += new System.EventHandler(this.button2_bestScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 518);
            this.Controls.Add(this.button2_bestScores);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_flags);
            this.Controls.Add(this.label_hiddenCells);
            this.Controls.Add(this.label_numOfBombs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_LevelPicker);
            this.Controls.Add(this.panel_GridHolder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Minesweeper by Lucas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_GridHolder;
        private System.Windows.Forms.ComboBox comboBox_LevelPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_numOfBombs;
        private System.Windows.Forms.Label label_hiddenCells;
        private System.Windows.Forms.Label label_flags;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button2_bestScores;
    }
}

