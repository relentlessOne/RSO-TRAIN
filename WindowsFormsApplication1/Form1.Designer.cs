namespace WindowsFormsApplication1
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
            this.cityA = new System.Windows.Forms.TextBox();
            this.cityB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.startBox = new System.Windows.Forms.ComboBox();
            this.stopBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityA
            // 
            this.cityA.Location = new System.Drawing.Point(107, 28);
            this.cityA.Name = "cityA";
            this.cityA.Size = new System.Drawing.Size(121, 20);
            this.cityA.TabIndex = 0;
            // 
            // cityB
            // 
            this.cityB.Location = new System.Drawing.Point(107, 60);
            this.cityB.Name = "cityB";
            this.cityB.Size = new System.Drawing.Size(121, 20);
            this.cityB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miasto A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miasto B";
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(107, 172);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(121, 23);
            this.checkBtn.TabIndex = 4;
            this.checkBtn.Text = "Sprawdź";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // startBox
            // 
            this.startBox.FormattingEnabled = true;
            this.startBox.Location = new System.Drawing.Point(107, 97);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(121, 21);
            this.startBox.TabIndex = 5;
            // 
            // stopBox
            // 
            this.stopBox.FormattingEnabled = true;
            this.stopBox.Location = new System.Drawing.Point(107, 133);
            this.stopBox.Name = "stopBox";
            this.stopBox.Size = new System.Drawing.Size(121, 21);
            this.stopBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czas wyjazdu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Czas przyjazdu";
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(1, 221);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outBox.Size = new System.Drawing.Size(283, 195);
            this.outBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 416);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopBox);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityB);
            this.Controls.Add(this.cityA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityA;
        private System.Windows.Forms.TextBox cityB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.ComboBox startBox;
        private System.Windows.Forms.ComboBox stopBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outBox;
    }
}

