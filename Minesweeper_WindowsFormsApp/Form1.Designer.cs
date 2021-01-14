
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
            this.SuspendLayout();
            // 
            // panel_GridHolder
            // 
            this.panel_GridHolder.Location = new System.Drawing.Point(12, 74);
            this.panel_GridHolder.Name = "panel_GridHolder";
            this.panel_GridHolder.Size = new System.Drawing.Size(495, 442);
            this.panel_GridHolder.TabIndex = 0;
            // 
            // comboBox_LevelPicker
            // 
            this.comboBox_LevelPicker.FormattingEnabled = true;
            this.comboBox_LevelPicker.Items.AddRange(new object[] {
            "easy",
            "normal",
            "hard"});
            this.comboBox_LevelPicker.Location = new System.Drawing.Point(581, 87);
            this.comboBox_LevelPicker.Name = "comboBox_LevelPicker";
            this.comboBox_LevelPicker.Size = new System.Drawing.Size(162, 24);
            this.comboBox_LevelPicker.TabIndex = 1;
            this.comboBox_LevelPicker.Text = "easy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Draw Board";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_LevelPicker);
            this.Controls.Add(this.panel_GridHolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_GridHolder;
        private System.Windows.Forms.ComboBox comboBox_LevelPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

