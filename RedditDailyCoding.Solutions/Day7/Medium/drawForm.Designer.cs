namespace RedditDailyCoding.Solutions.Day7.Medium
{
    partial class DrawForm
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
            this.AngleTB = new System.Windows.Forms.TrackBar();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.LengthTB = new System.Windows.Forms.TrackBar();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.MultiplierTB = new System.Windows.Forms.TrackBar();
            this.MultiplierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AngleTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierTB)).BeginInit();
            this.SuspendLayout();
            // 
            // AngleTB
            // 
            this.AngleTB.LargeChange = 10;
            this.AngleTB.Location = new System.Drawing.Point(12, 704);
            this.AngleTB.Maximum = 150;
            this.AngleTB.Minimum = 30;
            this.AngleTB.Name = "AngleTB";
            this.AngleTB.Size = new System.Drawing.Size(104, 45);
            this.AngleTB.TabIndex = 0;
            this.AngleTB.TickFrequency = 5;
            this.AngleTB.Value = 45;
            this.AngleTB.Scroll += new System.EventHandler(this.AngleTB_ScrollX);
            this.AngleTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AngleTB_MouseUp);
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(44, 736);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(34, 13);
            this.AngleLabel.TabIndex = 1;
            this.AngleLabel.Text = "Angle";
            // 
            // LengthTB
            // 
            this.LengthTB.LargeChange = 40;
            this.LengthTB.Location = new System.Drawing.Point(139, 704);
            this.LengthTB.Maximum = 400;
            this.LengthTB.Minimum = 10;
            this.LengthTB.Name = "LengthTB";
            this.LengthTB.Size = new System.Drawing.Size(104, 45);
            this.LengthTB.SmallChange = 5;
            this.LengthTB.TabIndex = 0;
            this.LengthTB.TickFrequency = 20;
            this.LengthTB.Value = 200;
            this.LengthTB.Scroll += new System.EventHandler(this.LengthTB_ScrollX);
            this.LengthTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LengthTB_MouseUp);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(171, 736);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length";
            // 
            // MultiplierTB
            // 
            this.MultiplierTB.LargeChange = 10;
            this.MultiplierTB.Location = new System.Drawing.Point(260, 704);
            this.MultiplierTB.Maximum = 100;
            this.MultiplierTB.Name = "MultiplierTB";
            this.MultiplierTB.Size = new System.Drawing.Size(104, 45);
            this.MultiplierTB.TabIndex = 0;
            this.MultiplierTB.TickFrequency = 10;
            this.MultiplierTB.Value = 50;
            this.MultiplierTB.Scroll += new System.EventHandler(this.MultiplierTB_ScrollX);
            this.MultiplierTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MultiplierTB_MouseUp);
            // 
            // MultiplierLabel
            // 
            this.MultiplierLabel.AutoSize = true;
            this.MultiplierLabel.Location = new System.Drawing.Point(292, 736);
            this.MultiplierLabel.Name = "MultiplierLabel";
            this.MultiplierLabel.Size = new System.Drawing.Size(48, 13);
            this.MultiplierLabel.TabIndex = 1;
            this.MultiplierLabel.Text = "Multiplier";
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.MultiplierLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.MultiplierTB);
            this.Controls.Add(this.LengthTB);
            this.Controls.Add(this.AngleTB);
            this.Name = "DrawForm";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.AngleTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar AngleTB;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.TrackBar LengthTB;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TrackBar MultiplierTB;
        private System.Windows.Forms.Label MultiplierLabel;
    }
}