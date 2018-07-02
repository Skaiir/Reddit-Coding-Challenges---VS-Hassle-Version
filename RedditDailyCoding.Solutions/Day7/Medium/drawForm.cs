using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditDailyCoding.Solutions.Day7.Medium
{
    public partial class DrawForm : Form
    {      
        public DrawForm()
        {
            InitializeComponent();
        }

        private void DrawForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawRecursiveTree(g, this.Size.Width/2, this.Size.Height * 0.1f, 12, LengthTB.Value, MultiplierTB.Value / 100f, 0f, AngleTB.Value, Color.Blue, Color.Red);

        }

        private static void DrawRecursiveTree(Graphics g, float startX, float startY, int recursionCount, float length, float mulLength, float angle, float changeAngle, Color currentColor, Color finalColor)
        {
            if (recursionCount == 0) { return; }

            Pen tempPen = new Pen(currentColor, (float)Math.Log(length + 8) * 0.7f);

            float endX, endY;

            // Find the end points
            CalcPoints(startX, startY, length, angle, out endX, out endY);

            // Draw the line
            g.DrawLine(tempPen, startX, startY, endX, endY);

            Color newColor = Color.FromArgb((int)(currentColor.R * 0.7 + finalColor.R * 0.3), (int)(currentColor.G * 0.7 + finalColor.G * 0.3), (int)(currentColor.B * 0.7 + finalColor.B * 0.3));

            // Recursion
            DrawRecursiveTree(g, endX, endY, recursionCount - 1, length * mulLength, mulLength, angle + changeAngle, changeAngle, newColor, finalColor);
            DrawRecursiveTree(g, endX, endY, recursionCount - 1, length * mulLength, mulLength, angle - changeAngle, changeAngle, newColor, finalColor);

        }

        // Calculates out point from an input point and an angle
        private static void CalcPoints(float X1, float Y1, float len, float alpha, out float X2, out float Y2)
        {
            X2 = (float)(Math.Sin(Math.PI * alpha / 180) * len + X1);
            Y2 = (float)(Math.Cos(Math.PI * alpha / 180) * len + Y1);
        }


        private void AngleTB_MouseUp(object sender, MouseEventArgs e)
        {          
            Invalidate();
        }

        private void LengthTB_MouseUp(object sender, MouseEventArgs e)
        {
            Invalidate();
        }

        private void MultiplierTB_MouseUp(object sender, MouseEventArgs e)
        {
            Invalidate();
        }

        private void MultiplierTB_ScrollX(object sender, EventArgs e)
        {
            MultiplierLabel.Text = "Multiplier: " + MultiplierTB.Value / 100f;
        }

        private void LengthTB_ScrollX(object sender, EventArgs e)
        {
            LengthLabel.Text = "Length: " + LengthTB.Value;
        }

        private void AngleTB_ScrollX(object sender, EventArgs e)
        {
            AngleLabel.Text = "Angle: " + AngleTB.Value;
        }
    }
}
