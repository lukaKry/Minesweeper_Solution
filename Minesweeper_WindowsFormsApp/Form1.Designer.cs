
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
            this.panel_GridHolder = new System.Windows.Forms.Panel();
            this.comboBox_LevelPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_numOfBombs = new System.Windows.Forms.Label();
            this.label_hiddenCells = new System.Windows.Forms.Label();
            this.label_flags = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_GridHolder
            // 
            this.panel_GridHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_GridHolder.Location = new System.Drawing.Point(21, 26);
            this.panel_GridHolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_GridHolder.Name = "panel_GridHolder";
            this.panel_GridHolder.Size = new System.Drawing.Size(376, 376);
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
            this.comboBox_LevelPicker.Location = new System.Drawing.Point(478, 23);
            this.comboBox_LevelPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_LevelPicker.Name = "comboBox_LevelPicker";
            this.comboBox_LevelPicker.Size = new System.Drawing.Size(122, 21);
            this.comboBox_LevelPicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Draw Board";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_numOfBombs
            // 
            this.label_numOfBombs.AutoSize = true;
            this.label_numOfBombs.Location = new System.Drawing.Point(415, 326);
            this.label_numOfBombs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numOfBombs.Name = "label_numOfBombs";
            this.label_numOfBombs.Size = new System.Drawing.Size(94, 13);
            this.label_numOfBombs.TabIndex = 4;
            this.label_numOfBombs.Text = "Number of Bombs:";
            // 
            // label_hiddenCells
            // 
            this.label_hiddenCells.AutoSize = true;
            this.label_hiddenCells.Location = new System.Drawing.Point(415, 356);
            this.label_hiddenCells.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hiddenCells.Name = "label_hiddenCells";
            this.label_hiddenCells.Size = new System.Drawing.Size(81, 13);
            this.label_hiddenCells.TabIndex = 5;
            this.label_hiddenCells.Text = "Revealed Cells:";
            // 
            // label_flags
            // 
            this.label_flags.AutoSize = true;
            this.label_flags.Location = new System.Drawing.Point(415, 386);
            this.label_flags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_flags.Name = "label_flags";
            this.label_flags.Size = new System.Drawing.Size(113, 13);
            this.label_flags.TabIndex = 6;
            this.label_flags.Text = "Flags on the Minefield:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.Controls.Add(this.label_flags);
            this.Controls.Add(this.label_hiddenCells);
            this.Controls.Add(this.label_numOfBombs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_LevelPicker);
            this.Controls.Add(this.panel_GridHolder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

