
namespace Minesweeper_WindowsFormsApp
{
    partial class Form2
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
            this.listBox1_easy = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1_normal = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2_hard = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1_easy
            // 
            this.listBox1_easy.FormattingEnabled = true;
            this.listBox1_easy.ItemHeight = 16;
            this.listBox1_easy.Location = new System.Drawing.Point(18, 79);
            this.listBox1_easy.Name = "listBox1_easy";
            this.listBox1_easy.Size = new System.Drawing.Size(234, 244);
            this.listBox1_easy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Best Scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Level: easy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Level: normal";
            // 
            // listBox1_normal
            // 
            this.listBox1_normal.FormattingEnabled = true;
            this.listBox1_normal.ItemHeight = 16;
            this.listBox1_normal.Location = new System.Drawing.Point(286, 79);
            this.listBox1_normal.Name = "listBox1_normal";
            this.listBox1_normal.Size = new System.Drawing.Size(234, 244);
            this.listBox1_normal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Level: hard";
            // 
            // listBox2_hard
            // 
            this.listBox2_hard.FormattingEnabled = true;
            this.listBox2_hard.ItemHeight = 16;
            this.listBox2_hard.Location = new System.Drawing.Point(554, 79);
            this.listBox2_hard.Name = "listBox2_hard";
            this.listBox2_hard.Size = new System.Drawing.Size(234, 244);
            this.listBox2_hard.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2_hard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1_normal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_easy);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1_normal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2_hard;
    }
}